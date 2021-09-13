namespace ToDo.Kontrolki
{
    partial class LoginControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbHaslo = new System.Windows.Forms.TextBox();
            this.BtnZaloguj = new System.Windows.Forms.Button();
            this.BtnZalozKonto = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblWalidacjaLogowania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Lista Zadan";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(62, 263);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(67, 25);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Hasło";
            // 
            // TbLogin
            // 
            this.TbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbLogin.Location = new System.Drawing.Point(167, 154);
            this.TbLogin.Multiline = true;
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(186, 43);
            this.TbLogin.TabIndex = 3;
            this.TbLogin.TextChanged += new System.EventHandler(this.TbLogin_TextChanged);
            // 
            // TbHaslo
            // 
            this.TbHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbHaslo.Location = new System.Drawing.Point(167, 253);
            this.TbHaslo.Multiline = true;
            this.TbHaslo.Name = "TbHaslo";
            this.TbHaslo.PasswordChar = '*';
            this.TbHaslo.Size = new System.Drawing.Size(186, 45);
            this.TbHaslo.TabIndex = 4;
            // 
            // BtnZaloguj
            // 
            this.BtnZaloguj.BackColor = System.Drawing.Color.Honeydew;
            this.BtnZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZaloguj.Location = new System.Drawing.Point(133, 346);
            this.BtnZaloguj.Name = "BtnZaloguj";
            this.BtnZaloguj.Size = new System.Drawing.Size(198, 85);
            this.BtnZaloguj.TabIndex = 5;
            this.BtnZaloguj.Text = "Zaloguj";
            this.BtnZaloguj.UseVisualStyleBackColor = false;
            this.BtnZaloguj.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnZalozKonto
            // 
            this.BtnZalozKonto.BackColor = System.Drawing.Color.Honeydew;
            this.BtnZalozKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZalozKonto.Location = new System.Drawing.Point(133, 467);
            this.BtnZalozKonto.Name = "BtnZalozKonto";
            this.BtnZalozKonto.Size = new System.Drawing.Size(198, 86);
            this.BtnZalozKonto.TabIndex = 6;
            this.BtnZalozKonto.Text = "Załóż Konto";
            this.BtnZalozKonto.UseVisualStyleBackColor = false;
            this.BtnZalozKonto.Click += new System.EventHandler(this.BtnZalozKonto_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(64, 163);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 25);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // lblWalidacjaLogowania
            // 
            this.lblWalidacjaLogowania.AutoSize = true;
            this.lblWalidacjaLogowania.Location = new System.Drawing.Point(167, 216);
            this.lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
            this.lblWalidacjaLogowania.Size = new System.Drawing.Size(35, 13);
            this.lblWalidacjaLogowania.TabIndex = 8;
            this.lblWalidacjaLogowania.Text = "label2";
            this.lblWalidacjaLogowania.Visible = false;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.lblWalidacjaLogowania);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.BtnZalozKonto);
            this.Controls.Add(this.BtnZaloguj);
            this.Controls.Add(this.TbHaslo);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.label1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbHaslo;
        private System.Windows.Forms.Button BtnZaloguj;
        private System.Windows.Forms.Button BtnZalozKonto;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblWalidacjaLogowania;
    }
}
