namespace JogoDaVelha
{
    partial class frm_jogo_velha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_jogo_velha));
            this.img_grid = new System.Windows.Forms.PictureBox();
            this.img_a1 = new System.Windows.Forms.PictureBox();
            this.img_b3 = new System.Windows.Forms.PictureBox();
            this.img_a3 = new System.Windows.Forms.PictureBox();
            this.img_a2 = new System.Windows.Forms.PictureBox();
            this.img_b2 = new System.Windows.Forms.PictureBox();
            this.img_b1 = new System.Windows.Forms.PictureBox();
            this.img_c1 = new System.Windows.Forms.PictureBox();
            this.img_c3 = new System.Windows.Forms.PictureBox();
            this.img_c2 = new System.Windows.Forms.PictureBox();
            this.img_resultado = new System.Windows.Forms.PictureBox();
            this.lbl_o = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // img_grid
            // 
            this.img_grid.BackColor = System.Drawing.Color.Transparent;
            this.img_grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_grid.Image = ((System.Drawing.Image)(resources.GetObject("img_grid.Image")));
            this.img_grid.Location = new System.Drawing.Point(0, 0);
            this.img_grid.Name = "img_grid";
            this.img_grid.Size = new System.Drawing.Size(484, 452);
            this.img_grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_grid.TabIndex = 0;
            this.img_grid.TabStop = false;
            // 
            // img_a1
            // 
            this.img_a1.BackColor = System.Drawing.Color.Transparent;
            this.img_a1.Location = new System.Drawing.Point(24, 24);
            this.img_a1.Name = "img_a1";
            this.img_a1.Size = new System.Drawing.Size(102, 102);
            this.img_a1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_a1.TabIndex = 1;
            this.img_a1.TabStop = false;
            this.img_a1.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_b3
            // 
            this.img_b3.BackColor = System.Drawing.Color.Transparent;
            this.img_b3.Location = new System.Drawing.Point(346, 172);
            this.img_b3.Name = "img_b3";
            this.img_b3.Size = new System.Drawing.Size(102, 102);
            this.img_b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_b3.TabIndex = 2;
            this.img_b3.TabStop = false;
            this.img_b3.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_a3
            // 
            this.img_a3.BackColor = System.Drawing.Color.Transparent;
            this.img_a3.Location = new System.Drawing.Point(346, 24);
            this.img_a3.Name = "img_a3";
            this.img_a3.Size = new System.Drawing.Size(102, 102);
            this.img_a3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_a3.TabIndex = 3;
            this.img_a3.TabStop = false;
            this.img_a3.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_a2
            // 
            this.img_a2.BackColor = System.Drawing.Color.Transparent;
            this.img_a2.Location = new System.Drawing.Point(191, 24);
            this.img_a2.Name = "img_a2";
            this.img_a2.Size = new System.Drawing.Size(102, 102);
            this.img_a2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_a2.TabIndex = 4;
            this.img_a2.TabStop = false;
            this.img_a2.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_b2
            // 
            this.img_b2.BackColor = System.Drawing.Color.Transparent;
            this.img_b2.Location = new System.Drawing.Point(191, 174);
            this.img_b2.Name = "img_b2";
            this.img_b2.Size = new System.Drawing.Size(102, 102);
            this.img_b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_b2.TabIndex = 5;
            this.img_b2.TabStop = false;
            this.img_b2.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_b1
            // 
            this.img_b1.BackColor = System.Drawing.Color.Transparent;
            this.img_b1.Location = new System.Drawing.Point(24, 174);
            this.img_b1.Name = "img_b1";
            this.img_b1.Size = new System.Drawing.Size(102, 102);
            this.img_b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_b1.TabIndex = 6;
            this.img_b1.TabStop = false;
            this.img_b1.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_c1
            // 
            this.img_c1.BackColor = System.Drawing.Color.Transparent;
            this.img_c1.Location = new System.Drawing.Point(24, 336);
            this.img_c1.Name = "img_c1";
            this.img_c1.Size = new System.Drawing.Size(102, 102);
            this.img_c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_c1.TabIndex = 7;
            this.img_c1.TabStop = false;
            this.img_c1.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_c3
            // 
            this.img_c3.BackColor = System.Drawing.Color.Transparent;
            this.img_c3.Location = new System.Drawing.Point(346, 336);
            this.img_c3.Name = "img_c3";
            this.img_c3.Size = new System.Drawing.Size(102, 102);
            this.img_c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_c3.TabIndex = 8;
            this.img_c3.TabStop = false;
            this.img_c3.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_c2
            // 
            this.img_c2.BackColor = System.Drawing.Color.Transparent;
            this.img_c2.Location = new System.Drawing.Point(191, 336);
            this.img_c2.Name = "img_c2";
            this.img_c2.Size = new System.Drawing.Size(102, 102);
            this.img_c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_c2.TabIndex = 9;
            this.img_c2.TabStop = false;
            this.img_c2.Click += new System.EventHandler(this.jogar_click);
            // 
            // img_resultado
            // 
            this.img_resultado.BackColor = System.Drawing.Color.Transparent;
            this.img_resultado.Location = new System.Drawing.Point(0, 0);
            this.img_resultado.Name = "img_resultado";
            this.img_resultado.Size = new System.Drawing.Size(484, 450);
            this.img_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_resultado.TabIndex = 20;
            this.img_resultado.TabStop = false;
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.BackColor = System.Drawing.Color.Transparent;
            this.lbl_o.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_o.Location = new System.Drawing.Point(315, 471);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(64, 26);
            this.lbl_o.TabIndex = 26;
            this.lbl_o.Text = "O - 0";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.BackColor = System.Drawing.Color.Transparent;
            this.lbl_x.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_x.Location = new System.Drawing.Point(222, 471);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(64, 26);
            this.lbl_x.TabIndex = 25;
            this.lbl_x.Text = "X - 0";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(46, 471);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(161, 26);
            this.lbl_score.TabIndex = 24;
            this.lbl_score.Text = "Resultado: ";
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSize = true;
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(411, 470);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(37, 35);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_jogo_velha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 514);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.img_c2);
            this.Controls.Add(this.img_c3);
            this.Controls.Add(this.img_c1);
            this.Controls.Add(this.img_b1);
            this.Controls.Add(this.img_b2);
            this.Controls.Add(this.img_a2);
            this.Controls.Add(this.img_a3);
            this.Controls.Add(this.img_b3);
            this.Controls.Add(this.img_a1);
            this.Controls.Add(this.img_grid);
            this.Controls.Add(this.img_resultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_jogo_velha";
            this.Text = "Jogo da Velha";
            ((System.ComponentModel.ISupportInitialize)(this.img_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_a3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_grid;
        private System.Windows.Forms.PictureBox img_a1;
        private System.Windows.Forms.PictureBox img_b3;
        private System.Windows.Forms.PictureBox img_a3;
        private System.Windows.Forms.PictureBox img_a2;
        private System.Windows.Forms.PictureBox img_b2;
        private System.Windows.Forms.PictureBox img_b1;
        private System.Windows.Forms.PictureBox img_c1;
        private System.Windows.Forms.PictureBox img_c3;
        private System.Windows.Forms.PictureBox img_c2;
        private System.Windows.Forms.PictureBox img_resultado;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_reset;
    }
}

