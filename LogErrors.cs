namespace Spotify_Overlay;

public class LogErrors
{
    public void LogError(string message)
    {
        MessageBox.Show(message, "Spotify Overlay Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void LogWarning(string warning)
    {
        MessageBox.Show(warning, "Spotify Overlay Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public void LogStatus(string message)
    {
        MessageBox.Show(message, "Spotify Overlay Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}