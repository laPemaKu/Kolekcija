namespace Kolekcije_ocjenska
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
            this.txtPrviUpis = new System.Windows.Forms.TextBox();
            this.txtTreciUpis = new System.Windows.Forms.TextBox();
            this.txtDrugiUpis = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.cboxSpol = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrviUpis
            // 
            this.txtPrviUpis.Location = new System.Drawing.Point(13, 13);
            this.txtPrviUpis.Name = "txtPrviUpis";
            this.txtPrviUpis.Size = new System.Drawing.Size(100, 20);
            this.txtPrviUpis.TabIndex = 0;
            // 
            // txtTreciUpis
            // 
            this.txtTreciUpis.Location = new System.Drawing.Point(13, 66);
            this.txtTreciUpis.Name = "txtTreciUpis";
            this.txtTreciUpis.Size = new System.Drawing.Size(100, 20);
            this.txtTreciUpis.TabIndex = 3;
            // 
            // txtDrugiUpis
            // 
            this.txtDrugiUpis.Location = new System.Drawing.Point(13, 40);
            this.txtDrugiUpis.Name = "txtDrugiUpis";
            this.txtDrugiUpis.Size = new System.Drawing.Size(100, 20);
            this.txtDrugiUpis.TabIndex = 2;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(13, 119);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(100, 23);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "&Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(13, 149);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(100, 23);
            this.btnObrada.TabIndex = 7;
            this.btnObrada.Text = "&Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(13, 179);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(100, 23);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "&Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // cboxSpol
            // 
            this.cboxSpol.FormattingEnabled = true;
            this.cboxSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cboxSpol.Location = new System.Drawing.Point(13, 92);
            this.cboxSpol.Name = "cboxSpol";
            this.cboxSpol.Size = new System.Drawing.Size(100, 21);
            this.cboxSpol.TabIndex = 4;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(131, 13);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(581, 298);
            this.txtIspis.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 403);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cboxSpol);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtDrugiUpis);
            this.Controls.Add(this.txtTreciUpis);
            this.Controls.Add(this.txtPrviUpis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrviUpis;
        private System.Windows.Forms.TextBox txtTreciUpis;
        private System.Windows.Forms.TextBox txtDrugiUpis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.ComboBox cboxSpol;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnSave;
    }
}

