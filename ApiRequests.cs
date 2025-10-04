using System.Net;
using SpotifyAPI.Web;

namespace Spotify_Overlay;

public class ApiRequests
{
    private string _clientId;
    private string _clientSecret;
    
    public void setClientId(string clientId, string clientSecret)
    {
       this._clientId = clientId;
       this._clientSecret = clientSecret;
    }
    
    // Returns a configured SpotifyClientConfig
    public SpotifyClientConfig GetConfig()
    {
        return SpotifyClientConfig.CreateDefault();
    }

    // Returns a LoginRequest for the Authorization Code Flow
    public LoginRequest GetLoginRequest(string redirectUri)
    {
        return new LoginRequest(
            new Uri(redirectUri),
            _clientId,
            LoginRequest.ResponseType.Code
        )
        {
            Scope = new[]
            {
                Scopes.UserReadCurrentlyPlaying,
                Scopes.UserReadPlaybackState
            }
        };
    }

    // Exchange code for a user token
    public async Task<SpotifyClient> GetTokenResponse(string code, string redirectUri)
    {
        var config = GetConfig();
        var oauth = new OAuthClient(config);

        var tokenResponse = await oauth.RequestToken(
            new AuthorizationCodeTokenRequest(
                _clientId,
                _clientSecret,
                code,
                new Uri(redirectUri)
            )
        );

        return new SpotifyClient(tokenResponse.AccessToken);
    }
}