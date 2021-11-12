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
            this.pnCartela = new System.Windows.Forms.Panel();
            this.rbLotomania = new System.Windows.Forms.RadioButton();
            this.rbLotofacil = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbMegaSena = new System.Windows.Forms.RadioButton();
            this.btnSortear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERADOR DE CARTELAS DE LOTERIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCartela
            // 
            this.pnCartela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCartela.Location = new System.Drawing.Point(0, 31);
            this.pnCartela.Name = "pnCartela";
            this.pnCartela.Size = new System.Drawing.Size(1008, 482);
            this.pnCartela.TabIndex = 2;
            // 
            // rbLotomania
            // 
            this.rbLotomania.AutoSize = true;
            this.rbLotomania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(141)))), ((int)(((byte)(0)))));
            this.rbLotomania.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbLotomania.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbLotomania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(47)))), ((int)(((byte)(198)))));
            this.rbLotomania.Location = new System.Drawing.Point(119, 0);
            this.rbLotomania.Margin = new System.Windows.Forms.Padding(0);
            this.rbLotomania.Name = "rbLotomania";
            this.rbLotomania.Padding = new System.Windows.Forms.Padding(16);
            this.rbLotomania.Size = new System.Drawing.Size(123, 48);
            this.rbLotomania.TabIndex = 2;
            this.rbLotomania.Text = "LOTOMANIA";
            this.rbLotomania.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLotomania.UseVisualStyleBackColor = false;
            // 
            // rbLotofacil
            // 
            this.rbLotofacil.AutoSize = true;
            this.rbLotofacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.rbLotofacil.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbLotofacil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLotofacil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(141)))), ((int)(((byte)(0)))));
            this.rbLotofacil.Location = new System.Drawing.Point(0, 0);
            this.rbLotofacil.Name = "rbLotofacil";
            this.rbLotofacil.Padding = new System.Windows.Forms.Padding(16);
            this.rbLotofacil.Size = new System.Drawing.Size(119, 48);
            this.rbLotofacil.TabIndex = 1;
            this.rbLotofacil.Text = "LOTOFÁCIL";
            this.rbLotofacil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLotofacil.UseVisualStyleBackColor = false;
            // 
            // rbQuina
            // 
            this.rbQuina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(47)))), ((int)(((byte)(198)))));
            this.rbQuina.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbQuina.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbQuina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(141)))), ((int)(((byte)(0)))));
            this.rbQuina.Location = new System.Drawing.Point(242, 0);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Padding = new System.Windows.Forms.Padding(16);
            this.rbQuina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbQuina.Size = new System.Drawing.Size(104, 48);
            this.rbQuina.TabIndex = 2;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbQuina.UseVisualStyleBackColor = false;
            // 
            // rbMegaSena
            // 
            this.rbMegaSena.AutoSize = true;
            this.rbMegaSena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.rbMegaSena.Checked = true;
            this.rbMegaSena.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbMegaSena.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbMegaSena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(47)))), ((int)(((byte)(198)))));
            this.rbMegaSena.Location = new System.Drawing.Point(346, 0);
            this.rbMegaSena.Name = "rbMegaSena";
            this.rbMegaSena.Padding = new System.Windows.Forms.Padding(16);
            this.rbMegaSena.Size = new System.Drawing.Size(120, 48);
            this.rbMegaSena.TabIndex = 1;
            this.rbMegaSena.TabStop = true;
            this.rbMegaSena.Text = "MEGA SENA";
            this.rbMegaSena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMegaSena.UseVisualStyleBackColor = false;
            // 
            // btnSortear
            // 
            this.btnSortear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSortear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnSortear.Location = new System.Drawing.Point(713, 0);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(295, 48);
            this.btnSortear.TabIndex = 5;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnSortear);
            this.panel3.Controls.Add(this.rbMegaSena);
            this.panel3.Controls.Add(this.rbQuina);
            this.panel3.Controls.Add(this.rbLotomania);
            this.panel3.Controls.Add(this.rbLotofacil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 48);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnCartela);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Projeto Loteria";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCartela;
        private System.Windows.Forms.RadioButton rbMegaSena;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotofacil;
        private System.Windows.Forms.RadioButton rbLotomania;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSortear;
    }
}

