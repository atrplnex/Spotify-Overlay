namespace Spotify_Overlay;

partial class SpotifyOverlay
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        clientIDHold = new System.Windows.Forms.TextBox();
        LClientID = new System.Windows.Forms.Label();
        LClientSecret = new System.Windows.Forms.Label();
        clientSecret = new System.Windows.Forms.TextBox();
        openOverlay = new System.Windows.Forms.Button();
        openUI = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // clientIDHold
        // 
        clientIDHold.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        clientIDHold.Location = new System.Drawing.Point(12, 37);
        clientIDHold.Name = "clientIDHold";
        clientIDHold.Size = new System.Drawing.Size(255, 27);
        clientIDHold.TabIndex = 2;
        // 
        // LClientID
        // 
        LClientID.BackColor = System.Drawing.Color.Transparent;
        LClientID.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LClientID.Location = new System.Drawing.Point(12, 9);
        LClientID.Name = "LClientID";
        LClientID.Size = new System.Drawing.Size(255, 25);
        LClientID.TabIndex = 0;
        LClientID.Text = "Client ID";
        LClientID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        LClientID.Click += LClientID_Click;
        // 
        // LClientSecret
        // 
        LClientSecret.BackColor = System.Drawing.Color.Transparent;
        LClientSecret.Cursor = System.Windows.Forms.Cursors.Arrow;
        LClientSecret.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LClientSecret.Location = new System.Drawing.Point(12, 67);
        LClientSecret.Name = "LClientSecret";
        LClientSecret.Size = new System.Drawing.Size(255, 25);
        LClientSecret.TabIndex = 1;
        LClientSecret.Text = "Client Secret";
        LClientSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        LClientSecret.Click += LClientSecret_Click;
        // 
        // clientSecret
        // 
        clientSecret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        clientSecret.Location = new System.Drawing.Point(12, 95);
        clientSecret.Name = "clientSecret";
        clientSecret.Size = new System.Drawing.Size(255, 27);
        clientSecret.TabIndex = 3;
        // 
        // openOverlay
        // 
        openOverlay.BackColor = System.Drawing.Color.Honeydew;
        openOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
        openOverlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
        openOverlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        openOverlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        openOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        openOverlay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        openOverlay.ForeColor = System.Drawing.Color.Black;
        openOverlay.Location = new System.Drawing.Point(12, 128);
        openOverlay.Name = "openOverlay";
        openOverlay.Size = new System.Drawing.Size(125, 40);
        openOverlay.TabIndex = 4;
        openOverlay.Text = "Connect Client";
        openOverlay.UseVisualStyleBackColor = false;
        openOverlay.Click += openOverlay_Click;
        // 
        // openUI
        // 
        openUI.BackColor = System.Drawing.Color.Honeydew;
        openUI.Cursor = System.Windows.Forms.Cursors.Hand;
        openUI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
        openUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        openUI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        openUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        openUI.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        openUI.ForeColor = System.Drawing.Color.Black;
        openUI.Location = new System.Drawing.Point(142, 128);
        openUI.Name = "openUI";
        openUI.Size = new System.Drawing.Size(125, 40);
        openUI.TabIndex = 5;
        openUI.Text = "Open Overlay";
        openUI.UseVisualStyleBackColor = false;
        openUI.Click += openUI_Click;
        // 
        // SpotifyOverlay
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)255)), ((int)((byte)192)));
        ClientSize = new System.Drawing.Size(279, 176);
        Controls.Add(openUI);
        Controls.Add(openOverlay);
        Controls.Add(LClientSecret);
        Controls.Add(clientSecret);
        Controls.Add(LClientID);
        Controls.Add(clientIDHold);
        Cursor = System.Windows.Forms.Cursors.Arrow;
        Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Opacity = 0.9D;
        Text = "Spotify Overlay";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button openUI;

    private System.Windows.Forms.Label LClientSecret;
    private System.Windows.Forms.TextBox clientSecret;
    private System.Windows.Forms.Button openOverlay;

    private System.Windows.Forms.Label LClientID;

    private System.Windows.Forms.TextBox clientIDHold;

    #endregion
}