namespace WindowsFormsAppMatosGestion
{
    partial class AddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.ClientName = new System.Windows.Forms.TextBox();
            this.AdresseClient = new System.Windows.Forms.TextBox();
            this.EmailClient = new System.Windows.Forms.TextBox();
            this.TelClient = new System.Windows.Forms.TextBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(254, 34);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(238, 22);
            this.ClientName.TabIndex = 0;
            // 
            // AdresseClient
            // 
            this.AdresseClient.Location = new System.Drawing.Point(254, 104);
            this.AdresseClient.Name = "AdresseClient";
            this.AdresseClient.Size = new System.Drawing.Size(238, 22);
            this.AdresseClient.TabIndex = 1;
            // 
            // EmailClient
            // 
            this.EmailClient.Location = new System.Drawing.Point(254, 164);
            this.EmailClient.Name = "EmailClient";
            this.EmailClient.Size = new System.Drawing.Size(238, 22);
            this.EmailClient.TabIndex = 2;
            // 
            // TelClient
            // 
            this.TelClient.Location = new System.Drawing.Point(254, 242);
            this.TelClient.Name = "TelClient";
            this.TelClient.Size = new System.Drawing.Size(238, 22);
            this.TelClient.TabIndex = 3;
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(254, 325);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(238, 23);
            this.Enregistrer.TabIndex = 4;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tel";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.TelClient);
            this.Controls.Add(this.EmailClient);
            this.Controls.Add(this.AdresseClient);
            this.Controls.Add(this.ClientName);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox AdresseClient;
        private System.Windows.Forms.TextBox EmailClient;
        private System.Windows.Forms.TextBox TelClient;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}