namespace ToDo.Formularze
{
    partial class TodoTaskForm
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
            this.lblIdTaska = new System.Windows.Forms.Label();
            this.lblNazwaTaska = new System.Windows.Forms.Label();
            this.lblOpisTaska = new System.Windows.Forms.Label();
            this.txtNazwaTaska = new System.Windows.Forms.TextBox();
            this.txtOpisTaska = new System.Windows.Forms.TextBox();
            this.btnZapiszTask = new System.Windows.Forms.Button();
            this.lblNumerTaska = new System.Windows.Forms.Label();
            this.cbCzyZakonczone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblIdTaska
            // 
            this.lblIdTaska.AutoSize = true;
            this.lblIdTaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdTaska.Location = new System.Drawing.Point(64, 57);
            this.lblIdTaska.Name = "lblIdTaska";
            this.lblIdTaska.Size = new System.Drawing.Size(89, 29);
            this.lblIdTaska.TabIndex = 0;
            this.lblIdTaska.Text = "Numer";
            // 
            // lblNazwaTaska
            // 
            this.lblNazwaTaska.AutoSize = true;
            this.lblNazwaTaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaTaska.Location = new System.Drawing.Point(63, 145);
            this.lblNazwaTaska.Name = "lblNazwaTaska";
            this.lblNazwaTaska.Size = new System.Drawing.Size(122, 39);
            this.lblNazwaTaska.TabIndex = 1;
            this.lblNazwaTaska.Text = "Nazwa";
            // 
            // lblOpisTaska
            // 
            this.lblOpisTaska.AutoSize = true;
            this.lblOpisTaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisTaska.Location = new System.Drawing.Point(66, 305);
            this.lblOpisTaska.Name = "lblOpisTaska";
            this.lblOpisTaska.Size = new System.Drawing.Size(87, 39);
            this.lblOpisTaska.TabIndex = 2;
            this.lblOpisTaska.Text = "Opis";
            // 
            // txtNazwaTaska
            // 
            this.txtNazwaTaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaTaska.Location = new System.Drawing.Point(208, 135);
            this.txtNazwaTaska.Multiline = true;
            this.txtNazwaTaska.Name = "txtNazwaTaska";
            this.txtNazwaTaska.Size = new System.Drawing.Size(249, 54);
            this.txtNazwaTaska.TabIndex = 3;
            // 
            // txtOpisTaska
            // 
            this.txtOpisTaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpisTaska.Location = new System.Drawing.Point(208, 247);
            this.txtOpisTaska.Multiline = true;
            this.txtOpisTaska.Name = "txtOpisTaska";
            this.txtOpisTaska.Size = new System.Drawing.Size(350, 138);
            this.txtOpisTaska.TabIndex = 4;
            // 
            // btnZapiszTask
            // 
            this.btnZapiszTask.BackColor = System.Drawing.Color.Lime;
            this.btnZapiszTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapiszTask.Location = new System.Drawing.Point(660, 226);
            this.btnZapiszTask.Name = "btnZapiszTask";
            this.btnZapiszTask.Size = new System.Drawing.Size(119, 194);
            this.btnZapiszTask.TabIndex = 6;
            this.btnZapiszTask.Text = "🌭";
            this.btnZapiszTask.UseVisualStyleBackColor = false;
            this.btnZapiszTask.Click += new System.EventHandler(this.btnZapiszTask_Click);
            // 
            // lblNumerTaska
            // 
            this.lblNumerTaska.AutoSize = true;
            this.lblNumerTaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerTaska.Location = new System.Drawing.Point(203, 60);
            this.lblNumerTaska.Name = "lblNumerTaska";
            this.lblNumerTaska.Size = new System.Drawing.Size(0, 25);
            this.lblNumerTaska.TabIndex = 7;
            // 
            // cbCzyZakonczone
            // 
            this.cbCzyZakonczone.AutoSize = true;
            this.cbCzyZakonczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCzyZakonczone.Location = new System.Drawing.Point(514, 145);
            this.cbCzyZakonczone.Name = "cbCzyZakonczone";
            this.cbCzyZakonczone.Size = new System.Drawing.Size(202, 29);
            this.cbCzyZakonczone.TabIndex = 8;
            this.cbCzyZakonczone.Text = "Czy zakończone?";
            this.cbCzyZakonczone.UseVisualStyleBackColor = true;
            // 
            // TodoTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCzyZakonczone);
            this.Controls.Add(this.lblNumerTaska);
            this.Controls.Add(this.btnZapiszTask);
            this.Controls.Add(this.txtOpisTaska);
            this.Controls.Add(this.txtNazwaTaska);
            this.Controls.Add(this.lblOpisTaska);
            this.Controls.Add(this.lblNazwaTaska);
            this.Controls.Add(this.lblIdTaska);
            this.Name = "TodoTaskForm";
            this.Text = "TodoTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdTaska;
        private System.Windows.Forms.Label lblNazwaTaska;
        private System.Windows.Forms.Label lblOpisTaska;
        private System.Windows.Forms.TextBox txtNazwaTaska;
        private System.Windows.Forms.TextBox txtOpisTaska;
        private System.Windows.Forms.Button btnZapiszTask;
        private System.Windows.Forms.Label lblNumerTaska;
        private System.Windows.Forms.CheckBox cbCzyZakonczone;
    }
}