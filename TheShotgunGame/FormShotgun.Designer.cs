namespace TheShotgunGame
{
    partial class FormShotgun
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShotgun));
            txtTitle = new TextBox();
            btnStart = new Button();
            btnPlayAgain = new Button();
            btnExitGameApp = new Button();
            btnShoot = new Button();
            btnReload = new Button();
            btnDodge = new Button();
            btnShotgun = new Button();
            lblPlayerAmmoText = new Label();
            lblComputerAmmoText = new Label();
            lblPlayerAmmo = new Label();
            lblComputerAmmo = new Label();
            lbxGameArea = new ListBox();
            btnExitApp = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.BurlyWood;
            txtTitle.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(-1, 3);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(808, 78);
            txtTitle.TabIndex = 0;
            txtTitle.TabStop = false;
            txtTitle.Text = "Shotgun";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.NavajoWhite;
            btnStart.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(341, 417);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 42);
            btnStart.TabIndex = 0;
            btnStart.TabStop = false;
            btnStart.Text = "Starta spelet";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.NavajoWhite;
            btnPlayAgain.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayAgain.Location = new Point(276, 465);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(130, 42);
            btnPlayAgain.TabIndex = 1;
            btnPlayAgain.TabStop = false;
            btnPlayAgain.Text = "Spela igen";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExitGameApp
            // 
            btnExitGameApp.BackColor = Color.NavajoWhite;
            btnExitGameApp.Font = new Font("Stencil", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitGameApp.Location = new Point(412, 465);
            btnExitGameApp.Name = "btnExitGameApp";
            btnExitGameApp.Size = new Size(130, 42);
            btnExitGameApp.TabIndex = 2;
            btnExitGameApp.TabStop = false;
            btnExitGameApp.Text = "Avsluta spelet";
            btnExitGameApp.UseVisualStyleBackColor = false;
            btnExitGameApp.Click += btnExitApp_Click;
            // 
            // btnShoot
            // 
            btnShoot.BackColor = Color.SandyBrown;
            btnShoot.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShoot.Location = new Point(140, 524);
            btnShoot.Name = "btnShoot";
            btnShoot.Size = new Size(130, 42);
            btnShoot.TabIndex = 4;
            btnShoot.TabStop = false;
            btnShoot.Text = "Skjut";
            btnShoot.UseVisualStyleBackColor = false;
            btnShoot.Click += btnShoot_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.SandyBrown;
            btnReload.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(276, 524);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(130, 42);
            btnReload.TabIndex = 5;
            btnReload.TabStop = false;
            btnReload.Text = "Ladda";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += bntReload_Click;
            // 
            // btnDodge
            // 
            btnDodge.BackColor = Color.SandyBrown;
            btnDodge.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodge.Location = new Point(412, 524);
            btnDodge.Name = "btnDodge";
            btnDodge.Size = new Size(130, 42);
            btnDodge.TabIndex = 6;
            btnDodge.TabStop = false;
            btnDodge.Text = "Blocka";
            btnDodge.UseVisualStyleBackColor = false;
            btnDodge.Click += btnDodge_Click;
            // 
            // btnShotgun
            // 
            btnShotgun.BackColor = Color.IndianRed;
            btnShotgun.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShotgun.Location = new Point(548, 524);
            btnShotgun.Name = "btnShotgun";
            btnShotgun.Size = new Size(130, 42);
            btnShotgun.TabIndex = 7;
            btnShotgun.TabStop = false;
            btnShotgun.Text = "SHOTGUN";
            btnShotgun.UseVisualStyleBackColor = false;
            btnShotgun.Click += btnShotgun_Click;
            // 
            // lblPlayerAmmoText
            // 
            lblPlayerAmmoText.AutoSize = true;
            lblPlayerAmmoText.BackColor = Color.Sienna;
            lblPlayerAmmoText.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerAmmoText.Location = new Point(271, 582);
            lblPlayerAmmoText.Name = "lblPlayerAmmoText";
            lblPlayerAmmoText.Size = new Size(145, 18);
            lblPlayerAmmoText.TabIndex = 8;
            lblPlayerAmmoText.Text = "Spelarens Skott:";
            // 
            // lblComputerAmmoText
            // 
            lblComputerAmmoText.AutoSize = true;
            lblComputerAmmoText.BackColor = Color.Sienna;
            lblComputerAmmoText.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputerAmmoText.Location = new Point(421, 582);
            lblComputerAmmoText.Name = "lblComputerAmmoText";
            lblComputerAmmoText.Size = new Size(130, 18);
            lblComputerAmmoText.TabIndex = 9;
            lblComputerAmmoText.Text = "Datorns Skott:";
            // 
            // lblPlayerAmmo
            // 
            lblPlayerAmmo.AutoSize = true;
            lblPlayerAmmo.BackColor = Color.DarkSalmon;
            lblPlayerAmmo.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerAmmo.Location = new Point(323, 602);
            lblPlayerAmmo.Name = "lblPlayerAmmo";
            lblPlayerAmmo.Size = new Size(0, 18);
            lblPlayerAmmo.TabIndex = 10;
            // 
            // lblComputerAmmo
            // 
            lblComputerAmmo.AutoSize = true;
            lblComputerAmmo.BackColor = Color.DarkSalmon;
            lblComputerAmmo.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputerAmmo.Location = new Point(459, 602);
            lblComputerAmmo.Name = "lblComputerAmmo";
            lblComputerAmmo.Size = new Size(0, 18);
            lblComputerAmmo.TabIndex = 11;
            // 
            // lbxGameArea
            // 
            lbxGameArea.BackColor = SystemColors.Info;
            lbxGameArea.Font = new Font("Lucida Calligraphy", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxGameArea.FormattingEnabled = true;
            lbxGameArea.ItemHeight = 17;
            lbxGameArea.Location = new Point(45, 87);
            lbxGameArea.Name = "lbxGameArea";
            lbxGameArea.Size = new Size(720, 310);
            lbxGameArea.TabIndex = 12;
            // 
            // btnExitApp
            // 
            btnExitApp.BackColor = Color.Peru;
            btnExitApp.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitApp.Location = new Point(677, 607);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(130, 50);
            btnExitApp.TabIndex = 13;
            btnExitApp.Text = "Avsluta programmet";
            btnExitApp.UseVisualStyleBackColor = false;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // FormShotgun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 656);
            Controls.Add(btnExitApp);
            Controls.Add(lbxGameArea);
            Controls.Add(lblComputerAmmo);
            Controls.Add(lblPlayerAmmo);
            Controls.Add(lblComputerAmmoText);
            Controls.Add(lblPlayerAmmoText);
            Controls.Add(btnShotgun);
            Controls.Add(btnDodge);
            Controls.Add(btnReload);
            Controls.Add(btnShoot);
            Controls.Add(btnExitGameApp);
            Controls.Add(btnPlayAgain);
            Controls.Add(btnStart);
            Controls.Add(txtTitle);
            Name = "FormShotgun";
            Text = "Let's play Shotgun!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Button btnStart;
        private Button btnPlayAgain;
        private Button btnExitGameApp;
        private Button btnShoot;
        private Button btnReload;
        private Button btnDodge;
        private Button btnShotgun;
        private Label lblPlayerAmmoText;
        private Label lblComputerAmmoText;
        private Label lblPlayerAmmo;
        private Label lblComputerAmmo;
        private ListBox lbxGameArea;
        private Button btnExitApp;
    }
}
