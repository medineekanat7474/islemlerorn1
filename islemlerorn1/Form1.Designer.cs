namespace islemlerorn1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı2";
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(90, 44);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(100, 20);
            this.txtSayı1.TabIndex = 2;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(90, 106);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(100, 20);
            this.txtSayı2.TabIndex = 3;
            // 
            // btnToplam
            // 
            this.btnToplam.BackColor = System.Drawing.Color.Silver;
            this.btnToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplam.ForeColor = System.Drawing.Color.Black;
            this.btnToplam.Location = new System.Drawing.Point(209, 43);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(69, 33);
            this.btnToplam.TabIndex = 4;
            this.btnToplam.Text = "toplam";
            this.btnToplam.UseVisualStyleBackColor = false;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.Silver;
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.ForeColor = System.Drawing.Color.Black;
            this.btnCikar.Location = new System.Drawing.Point(303, 43);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(69, 33);
            this.btnCikar.TabIndex = 5;
            this.btnCikar.Text = "çıkar";
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.Color.Silver;
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.ForeColor = System.Drawing.Color.Black;
            this.btnCarp.Location = new System.Drawing.Point(209, 103);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(69, 34);
            this.btnCarp.TabIndex = 6;
            this.btnCarp.Text = "çarp";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.Color.Silver;
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBol.ForeColor = System.Drawing.Color.Black;
            this.btnBol.Location = new System.Drawing.Point(303, 103);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(69, 34);
            this.btnBol.TabIndex = 7;
            this.btnBol.Text = "böl";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(90, 152);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(49, 15);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "sonuc:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(417, 191);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblSonuc;
    }
}

