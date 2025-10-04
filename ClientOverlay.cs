using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SpotifyAPI.Web;
using Color = SFML.Graphics.Color;
using Font = SFML.Graphics.Font;

namespace Spotify_Overlay;

public class ClientOverlay
{
    private SpotifyClient _client;
    public bool IsClientOpened { get; private set; } = false;

    public ClientOverlay(SpotifyClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public void OpenClient()
    {
        if (this.IsClientOpened) return;

        this.IsClientOpened = true;

        var window = new RenderWindow(new VideoMode(400, 200), "Spotify Overlay", Styles.None);
        window.SetFramerateLimit(60);
        window.Closed += (s, e) => window.Close();
        
        var background = new RectangleShape(new Vector2f(400, 200))
        {
            FillColor = new Color(30, 30, 30, 220)
        };
        
        Font font;
        try
        {
            font = new Font("Fonts/DmSansRegular.ttf");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to load font: " + ex.Message);
            font = new Font(@"C:\Windows\Fonts\arial.ttf");
        }

        var songText = new Text("Loading...", font, 20)
        {
            FillColor = Color.White,
            Position = new Vector2f(20, 20)
        };

        while (window.IsOpen)
        {
            window.DispatchEvents();

            // Update Now Playing safely
            try
            {
                var nowPlaying = _client.Player.GetCurrentPlayback().Result;
                if (nowPlaying?.Item is FullTrack track)
                {
                    string artists = string.Join(", ", track.Artists.Select(a => a.Name));
                    songText.DisplayedString = $"{track.Name} - {artists}";
                }
                else
                {
                    songText.DisplayedString = "Nothing is playing";
                }
            }
            catch (AggregateException ae)
            {
                // Catch API errors (like invalid username / token)
                Console.WriteLine("Spotify API error: " + ae.InnerException?.Message);
                songText.DisplayedString = "Error fetching track";
            }

            window.Clear(Color.Transparent);
            window.Draw(background);
            window.Draw(songText);
            window.Display();
        }

        this.IsClientOpened = false;
    }
}