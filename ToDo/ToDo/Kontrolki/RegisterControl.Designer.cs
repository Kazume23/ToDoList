namespace ToDo.Kontrolki
{
    partial class RegisterControl
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
            this.btnCofnij = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblPowtorzHaslo = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.lblImieWalidacja = new System.Windows.Forms.Label();
            this.lblLoginWalidacja = new System.Windows.Forms.Label();
            this.lblHasloWalidacja = new System.Windows.Forms.Label();
            this.lblPowtorzHasloWalidacja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestracja";
            // 
            // btnCofnij
            // 
            this.btnCofnij.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnij.Location = new System.Drawing.Point(20, 29);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(106, 69);
            this.btnCofnij.TabIndex = 1;
            this.btnCofnij.Text = "⎌";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dane Nowego Użytkownika";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(119, 241);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(51, 25);
            this.lblImie.TabIndex = 3;
            this.lblImie.Text = "Imię";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(105, 304);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 25);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(103, 372);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(67, 25);
            this.lblHaslo.TabIndex = 8;
            this.lblHaslo.Text = "Hasło";
            // 
            // lblPowtorzHaslo
            // 
            this.lblPowtorzHaslo.AutoSize = true;
            this.lblPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPowtorzHaslo.Location = new System.Drawing.Point(20, 444);
            this.lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            this.lblPowtorzHaslo.Size = new System.Drawing.Size(150, 25);
            this.lblPowtorzHaslo.TabIndex = 9;
            this.lblPowtorzHaslo.Text = "Powtórz Hasło";
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImie.Location = new System.Drawing.Point(193, 241);
            this.tbImie.Multiline = true;
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(230, 39);
            this.tbImie.TabIndex = 10;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(193, 304);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(230, 39);
            this.tbLogin.TabIndex = 11;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(193, 372);
            this.tbHaslo.Multiline = true;
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(230, 39);
            this.tbHaslo.TabIndex = 12;
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(193, 444);
            this.tbPowtorzHaslo.Multiline = true;
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(230, 39);
            this.tbPowtorzHaslo.TabIndex = 13;
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarejestruj.Location = new System.Drawing.Point(124, 531);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(217, 71);
            this.btnZarejestruj.TabIndex = 14;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = true;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // lblImieWalidacja
            // 
            this.lblImieWalidacja.AutoSize = true;
            this.lblImieWalidacja.Location = new System.Drawing.Point(193, 285);
            this.lblImieWalidacja.Name = "lblImieWalidacja";
            this.lblImieWalidacja.Size = new System.Drawing.Size(35, 13);
            this.lblImieWalidacja.TabIndex = 15;
            this.lblImieWalidacja.Text = "label3";
            this.lblImieWalidacja.Visible = false;
            // 
            // lblLoginWalidacja
            // 
            this.lblLoginWalidacja.AutoSize = true;
            this.lblLoginWalidacja.Location = new System.Drawing.Point(196, 350);
            this.lblLoginWalidacja.Name = "lblLoginWalidacja";
            this.lblLoginWalidacja.Size = new System.Drawing.Size(35, 13);
            this.lblLoginWalidacja.TabIndex = 16;
            this.lblLoginWalidacja.Text = "label4";
            this.lblLoginWalidacja.Visible = false;
            // 
            // lblHasloWalidacja
            // 
            this.lblHasloWalidacja.AutoSize = true;
            this.lblHasloWalidacja.Location = new System.Drawing.Point(196, 425);
            this.lblHasloWalidacja.Name = "lblHasloWalidacja";
            this.lblHasloWalidacja.Size = new System.Drawing.Size(35, 13);
            this.lblHasloWalidacja.TabIndex = 17;
            this.lblHasloWalidacja.Text = "label5";
            this.lblHasloWalidacja.Visible = false;
            // 
            // lblPowtorzHasloWalidacja
            // 
            this.lblPowtorzHasloWalidacja.AutoSize = true;
            this.lblPowtorzHasloWalidacja.Location = new System.Drawing.Point(193, 490);
            this.lblPowtorzHasloWalidacja.Name = "lblPowtorzHasloWalidacja";
            this.lblPowtorzHasloWalidacja.Size = new System.Drawing.Size(35, 13);
            this.lblPowtorzHasloWalidacja.TabIndex = 18;
            this.lblPowtorzHasloWalidacja.Text = "label6";
            this.lblPowtorzHasloWalidacja.Visible = false;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.lblPowtorzHasloWalidacja);
            this.Controls.Add(this.lblHasloWalidacja);
            this.Controls.Add(this.lblLoginWalidacja);
            this.Controls.Add(this.lblImieWalidacja);
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.tbPowtorzHaslo);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.lblPowtorzHaslo);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.label1);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblPowtorzHaslo;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbPowtorzHaslo;
        private System.Windows.Forms.Button btnZarejestruj;
        private System.Windows.Forms.Label lblImieWalidacja;
        private System.Windows.Forms.Label lblLoginWalidacja;
        private System.Windows.Forms.Label lblHasloWalidacja;
        private System.Windows.Forms.Label lblPowtorzHasloWalidacja;
    }
}
