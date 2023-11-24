namespace TROCGames
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
            this.GbEscolha = new System.Windows.Forms.GroupBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPlaystation = new System.Windows.Forms.PictureBox();
            this.BtnNintendo = new System.Windows.Forms.PictureBox();
            this.BtnXbox = new System.Windows.Forms.PictureBox();
            this.GbEscolha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNintendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnXbox)).BeginInit();
            this.SuspendLayout();
            // 
            // GbEscolha
            // 
            this.GbEscolha.Controls.Add(this.BtnPlaystation);
            this.GbEscolha.Controls.Add(this.BtnNintendo);
            this.GbEscolha.Controls.Add(this.BtnXbox);
            this.GbEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEscolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbEscolha.Location = new System.Drawing.Point(62, 134);
            this.GbEscolha.Name = "GbEscolha";
            this.GbEscolha.Size = new System.Drawing.Size(304, 204);
            this.GbEscolha.TabIndex = 11;
            this.GbEscolha.TabStop = false;
            this.GbEscolha.Text = "Qual plataforma você deseja?";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblTitulo.Location = new System.Drawing.Point(120, 86);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(174, 37);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.Text = "Bem Vindo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TROCGames.Properties.Resources.Prancheta_1__7_;
            this.pictureBox2.Location = new System.Drawing.Point(117, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 88);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TROCGames.Properties.Resources._4274239_output_icon_asset_data_upload_or_exit_icon_glyph_symbol_in_your_web_site_design_logo_app_ui_webinar_video_chat_ect_vetor_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(379, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPlaystation
            // 
            this.BtnPlaystation.Image = global::TROCGames.Properties.Resources.playstation_4_logo_ps4_6__1_;
            this.BtnPlaystation.Location = new System.Drawing.Point(46, 44);
            this.BtnPlaystation.Name = "BtnPlaystation";
            this.BtnPlaystation.Size = new System.Drawing.Size(112, 88);
            this.BtnPlaystation.TabIndex = 10;
            this.BtnPlaystation.TabStop = false;
            // 
            // BtnNintendo
            // 
            this.BtnNintendo.Image = global::TROCGames.Properties.Resources.nintendo_logo_1_1__1_;
            this.BtnNintendo.Location = new System.Drawing.Point(65, 150);
            this.BtnNintendo.Name = "BtnNintendo";
            this.BtnNintendo.Size = new System.Drawing.Size(187, 42);
            this.BtnNintendo.TabIndex = 8;
            this.BtnNintendo.TabStop = false;
            // 
            // BtnXbox
            // 
            this.BtnXbox.Image = global::TROCGames.Properties.Resources._1024px_Xbox_one_logo_svg__1___1_;
            this.BtnXbox.Location = new System.Drawing.Point(164, 47);
            this.BtnXbox.Name = "BtnXbox";
            this.BtnXbox.Size = new System.Drawing.Size(88, 85);
            this.BtnXbox.TabIndex = 6;
            this.BtnXbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(433, 362);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GbEscolha);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbEscolha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNintendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnXbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BtnXbox;
        private System.Windows.Forms.PictureBox BtnNintendo;
        private System.Windows.Forms.PictureBox BtnPlaystation;
        private System.Windows.Forms.GroupBox GbEscolha;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

