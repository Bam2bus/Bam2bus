namespace Zarada
{
    partial class Glavni
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorez = new System.Windows.Forms.TextBox();
            this.Glavna = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblZarada1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblZarada2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblZarada3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblZarada4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj sati";
            // 
            // txtSati
            // 
            this.txtSati.Location = new System.Drawing.Point(97, 56);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(100, 20);
            this.txtSati.TabIndex = 1;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(97, 95);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena sata";
            // 
            // txtPorez
            // 
            this.txtPorez.Location = new System.Drawing.Point(97, 133);
            this.txtPorez.Name = "txtPorez";
            this.txtPorez.Size = new System.Drawing.Size(100, 20);
            this.txtPorez.TabIndex = 3;
            // 
            // Glavna
            // 
            this.Glavna.AutoSize = true;
            this.Glavna.Location = new System.Drawing.Point(23, 133);
            this.Glavna.Name = "Glavna";
            this.Glavna.Size = new System.Drawing.Size(45, 13);
            this.Glavna.TabIndex = 2;
            this.Glavna.Text = "Porez %";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(26, 203);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(598, 45);
            this.btnIzracunaj.TabIndex = 4;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zarada za unesene parametre";
            // 
            // lblZarada1
            // 
            this.lblZarada1.AutoSize = true;
            this.lblZarada1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZarada1.Location = new System.Drawing.Point(225, 269);
            this.lblZarada1.Name = "lblZarada1";
            this.lblZarada1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZarada1.Size = new System.Drawing.Size(32, 13);
            this.lblZarada1.TabIndex = 6;
            this.lblZarada1.Text = "0,00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 300);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(156, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Zarada za default cijenu(40) je: ";
            // 
            // lblZarada2
            // 
            this.lblZarada2.AutoSize = true;
            this.lblZarada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZarada2.Location = new System.Drawing.Point(225, 300);
            this.lblZarada2.Name = "lblZarada2";
            this.lblZarada2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZarada2.Size = new System.Drawing.Size(32, 13);
            this.lblZarada2.TabIndex = 6;
            this.lblZarada2.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Zarada za default stope poreza(20%) je:  ";
            // 
            // lblZarada3
            // 
            this.lblZarada3.AutoSize = true;
            this.lblZarada3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZarada3.Location = new System.Drawing.Point(225, 337);
            this.lblZarada3.Name = "lblZarada3";
            this.lblZarada3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZarada3.Size = new System.Drawing.Size(32, 13);
            this.lblZarada3.TabIndex = 6;
            this.lblZarada3.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Zarada za default cijenu je: ";
            // 
            // lblZarada4
            // 
            this.lblZarada4.AutoSize = true;
            this.lblZarada4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZarada4.Location = new System.Drawing.Point(225, 371);
            this.lblZarada4.Name = "lblZarada4";
            this.lblZarada4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZarada4.Size = new System.Drawing.Size(32, 13);
            this.lblZarada4.TabIndex = 6;
            this.lblZarada4.Text = "0,00";
            // 
            // Glavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZarada4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblZarada3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblZarada2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblZarada1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtPorez);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.Glavna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSati);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Glavni";
            this.Text = "Zarada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorez;
        private System.Windows.Forms.Label Glavna;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblZarada1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblZarada2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblZarada3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblZarada4;
    }
}

