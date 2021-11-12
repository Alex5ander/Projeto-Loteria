namespace Projeto_Loteria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbLotomania = new System.Windows.Forms.RadioButton();
            this.rbLotofacil = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbMegaSena = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERADOR DE CARTELAS DE LOTERIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 530);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbMegaSena);
            this.panel2.Controls.Add(this.rbQuina);
            this.panel2.Controls.Add(this.rbLotofacil);
            this.panel2.Controls.Add(this.rbLotomania);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 88);
            this.panel2.TabIndex = 0;
            // 
            // rbLotomania
            // 
            this.rbLotomania.AutoSize = true;
            this.rbLotomania.Location = new System.Drawing.Point(178, 30);
            this.rbLotomania.Name = "rbLotomania";
            this.rbLotomania.Size = new System.Drawing.Size(85, 17);
            this.rbLotomania.TabIndex = 0;
            this.rbLotomania.TabStop = true;
            this.rbLotomania.Text = "radioButton1";
            this.rbLotomania.UseVisualStyleBackColor = true;
            // 
            // rbLotofacil
            // 
            this.rbLotofacil.AutoSize = true;
            this.rbLotofacil.Location = new System.Drawing.Point(352, 30);
            this.rbLotofacil.Name = "rbLotofacil";
            this.rbLotofacil.Size = new System.Drawing.Size(85, 17);
            this.rbLotofacil.TabIndex = 1;
            this.rbLotofacil.TabStop = true;
            this.rbLotofacil.Text = "radioButton1";
            this.rbLotofacil.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(570, 30);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(85, 17);
            this.rbQuina.TabIndex = 2;
            this.rbQuina.TabStop = true;
            this.rbQuina.Text = "radioButton2";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbMegaSena
            // 
            this.rbMegaSena.AutoSize = true;
            this.rbMegaSena.Location = new System.Drawing.Point(28, 30);
            this.rbMegaSena.Name = "rbMegaSena";
            this.rbMegaSena.Size = new System.Drawing.Size(85, 17);
            this.rbMegaSena.TabIndex = 3;
            this.rbMegaSena.TabStop = true;
            this.rbMegaSena.Text = "radioButton1";
            this.rbMegaSena.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Projeto Loteria";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMegaSena;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotofacil;
        private System.Windows.Forms.RadioButton rbLotomania;
    }
}

