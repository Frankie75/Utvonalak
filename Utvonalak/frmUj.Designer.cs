namespace Utvonalak
{
    partial class frmUj
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbKeresztnev = new System.Windows.Forms.TextBox();
            this.tbVezeteknev = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUjfelvetele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(167, 77);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(228, 26);
            this.tbId.TabIndex = 0;
            // 
            // tbKeresztnev
            // 
            this.tbKeresztnev.Location = new System.Drawing.Point(167, 141);
            this.tbKeresztnev.Name = "tbKeresztnev";
            this.tbKeresztnev.Size = new System.Drawing.Size(228, 26);
            this.tbKeresztnev.TabIndex = 1;
            // 
            // tbVezeteknev
            // 
            this.tbVezeteknev.Location = new System.Drawing.Point(167, 109);
            this.tbVezeteknev.Name = "tbVezeteknev";
            this.tbVezeteknev.Size = new System.Drawing.Size(228, 26);
            this.tbVezeteknev.TabIndex = 2;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(167, 205);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(228, 26);
            this.tbTelefon.TabIndex = 3;
            // 
            // tbVaros
            // 
            this.tbVaros.Location = new System.Drawing.Point(167, 173);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(228, 26);
            this.tbVaros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Uj turazo felvetele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Keresztnev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vezeteknev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Varos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // btnUjfelvetele
            // 
            this.btnUjfelvetele.Location = new System.Drawing.Point(52, 260);
            this.btnUjfelvetele.Name = "btnUjfelvetele";
            this.btnUjfelvetele.Size = new System.Drawing.Size(343, 60);
            this.btnUjfelvetele.TabIndex = 11;
            this.btnUjfelvetele.Text = "Uj turazo felvetele";
            this.btnUjfelvetele.UseVisualStyleBackColor = true;
            this.btnUjfelvetele.Click += new System.EventHandler(this.btnUjfelvetele_Click);
            // 
            // frmUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 362);
            this.Controls.Add(this.btnUjfelvetele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVaros);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbVezeteknev);
            this.Controls.Add(this.tbKeresztnev);
            this.Controls.Add(this.tbId);
            this.Name = "frmUj";
            this.Text = "Uj felvetele";
            this.Load += new System.EventHandler(this.frmUj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbKeresztnev;
        private System.Windows.Forms.TextBox tbVezeteknev;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUjfelvetele;
    }
}