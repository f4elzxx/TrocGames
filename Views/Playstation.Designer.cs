namespace TROCGames.View
{
    partial class Playstation
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
            this.DgvJogosPlaystation = new System.Windows.Forms.DataGridView();
            this.GrbCategoriaPlaystation = new System.Windows.Forms.GroupBox();
            this.GrbCarrinhoPlaystation = new System.Windows.Forms.GroupBox();
            this.BtnAdicionarPlaystation = new System.Windows.Forms.Button();
            this.CmCategoriaPlaystation = new System.Windows.Forms.ComboBox();
            this.CmbCarrinhoPlaystation = new System.Windows.Forms.ComboBox();
            this.LblTituloPlaystation = new System.Windows.Forms.Label();
            this.BtnExcluirPlaystation = new System.Windows.Forms.Button();
            this.BtnExitPlaystation = new System.Windows.Forms.PictureBox();
            this.BtnPlaystation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosPlaystation)).BeginInit();
            this.GrbCategoriaPlaystation.SuspendLayout();
            this.GrbCarrinhoPlaystation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitPlaystation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJogosPlaystation
            // 
            this.DgvJogosPlaystation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJogosPlaystation.Location = new System.Drawing.Point(57, 64);
            this.DgvJogosPlaystation.Name = "DgvJogosPlaystation";
            this.DgvJogosPlaystation.Size = new System.Drawing.Size(390, 304);
            this.DgvJogosPlaystation.TabIndex = 1;
            // 
            // GrbCategoriaPlaystation
            // 
            this.GrbCategoriaPlaystation.Controls.Add(this.CmCategoriaPlaystation);
            this.GrbCategoriaPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCategoriaPlaystation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GrbCategoriaPlaystation.Location = new System.Drawing.Point(57, 374);
            this.GrbCategoriaPlaystation.Name = "GrbCategoriaPlaystation";
            this.GrbCategoriaPlaystation.Size = new System.Drawing.Size(390, 66);
            this.GrbCategoriaPlaystation.TabIndex = 2;
            this.GrbCategoriaPlaystation.TabStop = false;
            this.GrbCategoriaPlaystation.Text = "Selecione a categoria";
            // 
            // GrbCarrinhoPlaystation
            // 
            this.GrbCarrinhoPlaystation.Controls.Add(this.BtnExcluirPlaystation);
            this.GrbCarrinhoPlaystation.Controls.Add(this.CmbCarrinhoPlaystation);
            this.GrbCarrinhoPlaystation.Controls.Add(this.BtnAdicionarPlaystation);
            this.GrbCarrinhoPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCarrinhoPlaystation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GrbCarrinhoPlaystation.Location = new System.Drawing.Point(57, 446);
            this.GrbCarrinhoPlaystation.Name = "GrbCarrinhoPlaystation";
            this.GrbCarrinhoPlaystation.Size = new System.Drawing.Size(390, 205);
            this.GrbCarrinhoPlaystation.TabIndex = 3;
            this.GrbCarrinhoPlaystation.TabStop = false;
            this.GrbCarrinhoPlaystation.Text = "Adicionar ao Carrinho";
            // 
            // BtnAdicionarPlaystation
            // 
            this.BtnAdicionarPlaystation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAdicionarPlaystation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarPlaystation.ForeColor = System.Drawing.Color.Black;
            this.BtnAdicionarPlaystation.Location = new System.Drawing.Point(6, 160);
            this.BtnAdicionarPlaystation.Name = "BtnAdicionarPlaystation";
            this.BtnAdicionarPlaystation.Size = new System.Drawing.Size(188, 39);
            this.BtnAdicionarPlaystation.TabIndex = 0;
            this.BtnAdicionarPlaystation.Text = "Adicionar";
            this.BtnAdicionarPlaystation.UseVisualStyleBackColor = false;
            // 
            // CmCategoriaPlaystation
            // 
            this.CmCategoriaPlaystation.FormattingEnabled = true;
            this.CmCategoriaPlaystation.Items.AddRange(new object[] {
            "Console\t",
            "Jogos",
            "Acessorios"});
            this.CmCategoriaPlaystation.Location = new System.Drawing.Point(6, 23);
            this.CmCategoriaPlaystation.Name = "CmCategoriaPlaystation";
            this.CmCategoriaPlaystation.Size = new System.Drawing.Size(377, 26);
            this.CmCategoriaPlaystation.TabIndex = 0;
            // 
            // CmbCarrinhoPlaystation
            // 
            this.CmbCarrinhoPlaystation.FormattingEnabled = true;
            this.CmbCarrinhoPlaystation.Location = new System.Drawing.Point(6, 23);
            this.CmbCarrinhoPlaystation.Name = "CmbCarrinhoPlaystation";
            this.CmbCarrinhoPlaystation.Size = new System.Drawing.Size(377, 26);
            this.CmbCarrinhoPlaystation.TabIndex = 4;
            // 
            // LblTituloPlaystation
            // 
            this.LblTituloPlaystation.AutoSize = true;
            this.LblTituloPlaystation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTituloPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPlaystation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblTituloPlaystation.Location = new System.Drawing.Point(152, 6);
            this.LblTituloPlaystation.Name = "LblTituloPlaystation";
            this.LblTituloPlaystation.Size = new System.Drawing.Size(266, 55);
            this.LblTituloPlaystation.TabIndex = 4;
            this.LblTituloPlaystation.Text = "PlayStation";
            // 
            // BtnExcluirPlaystation
            // 
            this.BtnExcluirPlaystation.BackColor = System.Drawing.Color.Red;
            this.BtnExcluirPlaystation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirPlaystation.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluirPlaystation.Location = new System.Drawing.Point(195, 160);
            this.BtnExcluirPlaystation.Name = "BtnExcluirPlaystation";
            this.BtnExcluirPlaystation.Size = new System.Drawing.Size(188, 39);
            this.BtnExcluirPlaystation.TabIndex = 5;
            this.BtnExcluirPlaystation.Text = "Excluir";
            this.BtnExcluirPlaystation.UseVisualStyleBackColor = false;
            // 
            // BtnExitPlaystation
            // 
            this.BtnExitPlaystation.Image = global::TROCGames.Properties.Resources.Prancheta_13;
            this.BtnExitPlaystation.Location = new System.Drawing.Point(435, -7);
            this.BtnExitPlaystation.Name = "BtnExitPlaystation";
            this.BtnExitPlaystation.Size = new System.Drawing.Size(82, 86);
            this.BtnExitPlaystation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExitPlaystation.TabIndex = 0;
            this.BtnExitPlaystation.TabStop = false;
            this.BtnExitPlaystation.Click += new System.EventHandler(this.BtnExitPlaystation_Click);
            // 
            // BtnPlaystation
            // 
            this.BtnPlaystation.Image = global::TROCGames.Properties.Resources.Prancheta_12;
            this.BtnPlaystation.Location = new System.Drawing.Point(77, -7);
            this.BtnPlaystation.Name = "BtnPlaystation";
            this.BtnPlaystation.Size = new System.Drawing.Size(87, 94);
            this.BtnPlaystation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPlaystation.TabIndex = 11;
            this.BtnPlaystation.TabStop = false;
            // 
            // Playstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 663);
            this.Controls.Add(this.DgvJogosPlaystation);
            this.Controls.Add(this.BtnPlaystation);
            this.Controls.Add(this.LblTituloPlaystation);
            this.Controls.Add(this.GrbCarrinhoPlaystation);
            this.Controls.Add(this.GrbCategoriaPlaystation);
            this.Controls.Add(this.BtnExitPlaystation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playstation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SS";
            this.Load += new System.EventHandler(this.Playstation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosPlaystation)).EndInit();
            this.GrbCategoriaPlaystation.ResumeLayout(false);
            this.GrbCarrinhoPlaystation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitPlaystation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnExitPlaystation;
        private System.Windows.Forms.DataGridView DgvJogosPlaystation;
        private System.Windows.Forms.GroupBox GrbCategoriaPlaystation;
        private System.Windows.Forms.ComboBox CmCategoriaPlaystation;
        private System.Windows.Forms.GroupBox GrbCarrinhoPlaystation;
        private System.Windows.Forms.Button BtnAdicionarPlaystation;
        private System.Windows.Forms.ComboBox CmbCarrinhoPlaystation;
        private System.Windows.Forms.Button BtnExcluirPlaystation;
        private System.Windows.Forms.Label LblTituloPlaystation;
        private System.Windows.Forms.PictureBox BtnPlaystation;
    }
}