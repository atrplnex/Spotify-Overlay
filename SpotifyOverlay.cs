using System.Net;
using SpotifyAPI.Web;

namespace Spotify_Overlay;

public partial class SpotifyOverlay : Form
{
    // Other Classes   
    private ErrorLists _errorLists = new ErrorLists();
    private ApiRequests _apiRequests = new ApiRequests();
    
    // Spotify Api 
    private SpotifyClient _client;
    private string _clientId;
    private string _clientSecret;
    // Requests
    private string _defaultURL = "http://127.0.0.1:5500/";
    
    // Overlay View
    private ClientOverlay _clientOverlay;
    public SpotifyOverlay()
    {
        InitializeComponent();
    }

    private async void openOverlay_Click(object sender, EventArgs e)
    {
        this._clientId = clientIDHold.Text;
        this._clientSecret = clientSecret.Text;

        if (new[] { this._clientId, this._clientSecret }.Any(string.IsNullOrEmpty))
        {
            this._errorLists.ClientErrors(this._clientId, this._clientSecret);
            return;
        }

        try
        {
            this._apiRequests.setClientId(this._clientId, this._clientSecret);
            // Api Request
            var loginRequest = this._apiRequests.GetLoginRequest(this._defaultURL);
            
            // Open Browser to Request User Permission
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = loginRequest.ToUri().ToString(),
                UseShellExecute = true
            });
            
            // Local Web Listener
            var listener = new HttpListener();
            listener.Prefixes.Add(this._defaultURL);
            listener.Start();
            
            var context = await listener.GetContextAsync();
            var code = context.Request.QueryString["code"];
            listener.Stop();
            
            if (string.IsNullOrEmpty(code))
            {
                this._errorLists.ClientConnectionFailed("Failed to get authorization code.");
                return;
            }

            var responseToken = await this._apiRequests.GetTokenResponse(code, this._defaultURL);
            this._client = responseToken;
            this._errorLists.ClientConnected();
        }
        catch (Exception ex)
        {
            this._errorLists.ClientConnectionFailed(ex.Message);
        }
    }
    
    private void openUI_Click(object sender, EventArgs e)
    {
        if (this._clientOverlay == null || !this._clientOverlay.IsClientOpened)
        {
            this._clientOverlay = new ClientOverlay(this._client);
            var thread = new System.Threading.Thread(this._clientOverlay.OpenClient);
            thread.IsBackground = true;
            thread.Start();
        }
    }

    private void LClientID_Click(object sender, EventArgs e)
    {
        
    }

    private void LClientSecret_Click(object sender, EventArgs e)
    {
        
    }
    
}
