namespace Spotify_Overlay;

public class ErrorLists
{
    public LogErrors logErrors = new LogErrors();
    
    public void ClientErrors(string clientId, string clientSecret)
    {
        if (clientId == "")
        {
            this.logErrors.LogError("Enter a Client ID!");
            return;
        }

        if (clientSecret == "")
        {
            this.logErrors.LogError("Enter a Client Secret!");
            return;
        }
    }

    public void ClientConnected()
    {
        this.logErrors.LogStatus("Client is Now Connected!");
    }

    public void ClientDisconnected()
    {
        this.logErrors.LogStatus("Client Disconnected!");
    }

    public void ClientConnectionFailed(string reason)
    {
        this.logErrors.LogError($"Client Connection Failed!\n{reason}");
    }
}