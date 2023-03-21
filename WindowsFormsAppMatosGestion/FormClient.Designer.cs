namespace WindowsFormsAppMatosGestion
{
    partial class FormClient
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
            this.Clients = new System.Windows.Forms.Label();
            this.InfosClients = new System.Windows.Forms.ListBox();
            this.Informations = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.Informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.Location = new System.Drawing.Point(37, 31);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(47, 16);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Clients";
            // 
            // InfosClients
            // 
            this.InfosClients.FormattingEnabled = true;
            this.InfosClients.ItemHeight = 16;
            this.InfosClients.Location = new System.Drawing.Point(40, 84);
            this.InfosClients.Name = "InfosClients";
            this.InfosClients.Size = new System.Drawing.Size(120, 340);
            this.InfosClients.TabIndex = 1;
            this.InfosClients.SelectedIndexChanged += new System.EventHandler(this.InfosClients_SelectedIndexChanged);
            // 
            // Informations
            // 
            this.Informations.Controls.Add(this.textBox4);
            this.Informations.Controls.Add(this.labelMail);
            this.Informations.Controls.Add(this.textBox3);
            this.Informations.Controls.Add(this.labelTel);
            this.Informations.Controls.Add(this.textBox2);
            this.Informations.Controls.Add(this.labelAdresse);
            this.Informations.Controls.Add(this.textBox1);
            this.Informations.Controls.Add(this.labelNom);
            this.Informations.Location = new System.Drawing.Point(266, 83);
            this.Informations.Name = "Informations";
            this.Informations.Size = new System.Drawing.Size(200, 247);
            this.Informations.TabIndex = 2;
            this.Informations.TabStop = false;
            this.Informations.Text = "Informations";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(7, 124);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(32, 16);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "Mail";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(7, 175);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(27, 16);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "Tel";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(6, 79);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(58, 16);
            this.labelAdresse.TabIndex = 2;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(93, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(6, 34);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(36, 16);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(690, 180);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(86, 23);
            this.buttonModifier.TabIndex = 3;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(690, 111);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(86, 23);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(690, 251);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(86, 23);
            this.buttonSupprimer.TabIndex = 5;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonFermer
            // 
            this.buttonFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFermer.Location = new System.Drawing.Point(690, 329);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(86, 23);
            this.buttonFermer.TabIndex = 6;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFermer_MouseClick);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.buttonFermer;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.Informations);
            this.Controls.Add(this.InfosClients);
            this.Controls.Add(this.Clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.Informations.ResumeLayout(false);
            this.Informations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.ListBox InfosClients;
        private System.Windows.Forms.GroupBox Informations;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonFermer;
    }
}