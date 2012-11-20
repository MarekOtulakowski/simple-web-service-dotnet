namespace Client_WebService_CSharp
{
    partial class F_Glowna
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
            this.B_wylicz = new System.Windows.Forms.Button();
            this.TB_x = new System.Windows.Forms.TextBox();
            this.TB_y = new System.Windows.Forms.TextBox();
            this.CB_operacja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_wynik = new System.Windows.Forms.TextBox();
            this.TB_bledy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_wylicz
            // 
            this.B_wylicz.Location = new System.Drawing.Point(13, 50);
            this.B_wylicz.Name = "B_wylicz";
            this.B_wylicz.Size = new System.Drawing.Size(290, 23);
            this.B_wylicz.TabIndex = 0;
            this.B_wylicz.Text = "Wylicz";
            this.B_wylicz.UseVisualStyleBackColor = true;
            this.B_wylicz.Click += new System.EventHandler(this.B_wylicz_Click);
            // 
            // TB_x
            // 
            this.TB_x.Location = new System.Drawing.Point(13, 15);
            this.TB_x.Name = "TB_x";
            this.TB_x.Size = new System.Drawing.Size(67, 20);
            this.TB_x.TabIndex = 1;
            this.TB_x.Text = "123";
            // 
            // TB_y
            // 
            this.TB_y.Location = new System.Drawing.Point(144, 15);
            this.TB_y.Name = "TB_y";
            this.TB_y.Size = new System.Drawing.Size(67, 20);
            this.TB_y.TabIndex = 2;
            this.TB_y.Text = "345";
            // 
            // CB_operacja
            // 
            this.CB_operacja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_operacja.FormattingEnabled = true;
            this.CB_operacja.Location = new System.Drawing.Point(86, 14);
            this.CB_operacja.Name = "CB_operacja";
            this.CB_operacja.Size = new System.Drawing.Size(52, 21);
            this.CB_operacja.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // TB_wynik
            // 
            this.TB_wynik.Enabled = false;
            this.TB_wynik.Location = new System.Drawing.Point(236, 15);
            this.TB_wynik.Name = "TB_wynik";
            this.TB_wynik.Size = new System.Drawing.Size(67, 20);
            this.TB_wynik.TabIndex = 5;
            // 
            // TB_bledy
            // 
            this.TB_bledy.Enabled = false;
            this.TB_bledy.Location = new System.Drawing.Point(13, 80);
            this.TB_bledy.Multiline = true;
            this.TB_bledy.Name = "TB_bledy";
            this.TB_bledy.Size = new System.Drawing.Size(290, 92);
            this.TB_bledy.TabIndex = 6;
            // 
            // F_Glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 184);
            this.Controls.Add(this.TB_bledy);
            this.Controls.Add(this.TB_wynik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_operacja);
            this.Controls.Add(this.TB_y);
            this.Controls.Add(this.TB_x);
            this.Controls.Add(this.B_wylicz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "F_Glowna";
            this.Text = "Client WebService CSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_wylicz;
        private System.Windows.Forms.TextBox TB_x;
        private System.Windows.Forms.TextBox TB_y;
        private System.Windows.Forms.ComboBox CB_operacja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_wynik;
        private System.Windows.Forms.TextBox TB_bledy;
    }
}

