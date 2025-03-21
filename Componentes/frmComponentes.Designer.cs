namespace Componentes
{
    partial class frmComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblListarProdutos = new System.Windows.Forms.Label();
            this.ltbListarProdutos = new System.Windows.Forms.ListBox();
            this.lblListarNome = new System.Windows.Forms.Label();
            this.cbbListaNomes = new System.Windows.Forms.ComboBox();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.pcbImagens);
            this.gpbComponentes.Controls.Add(this.ckbBanana);
            this.gpbComponentes.Controls.Add(this.ckbMesa);
            this.gpbComponentes.Controls.Add(this.ckbComputador);
            this.gpbComponentes.Controls.Add(this.lblEscolha);
            this.gpbComponentes.Controls.Add(this.ckbLivros);
            this.gpbComponentes.Controls.Add(this.cbbListaNomes);
            this.gpbComponentes.Controls.Add(this.lblListarNome);
            this.gpbComponentes.Controls.Add(this.ltbListarProdutos);
            this.gpbComponentes.Controls.Add(this.lblListarProdutos);
            this.gpbComponentes.Controls.Add(this.txtNome);
            this.gpbComponentes.Controls.Add(this.lblNome);
            this.gpbComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComponentes.Location = new System.Drawing.Point(19, 10);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(500, 461);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "Componentes";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(34, 81);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblListarProdutos
            // 
            this.lblListarProdutos.AutoSize = true;
            this.lblListarProdutos.Location = new System.Drawing.Point(241, 58);
            this.lblListarProdutos.Name = "lblListarProdutos";
            this.lblListarProdutos.Size = new System.Drawing.Size(115, 20);
            this.lblListarProdutos.TabIndex = 2;
            this.lblListarProdutos.Text = "Listar produtos";
            // 
            // ltbListarProdutos
            // 
            this.ltbListarProdutos.FormattingEnabled = true;
            this.ltbListarProdutos.ItemHeight = 20;
            this.ltbListarProdutos.Location = new System.Drawing.Point(245, 81);
            this.ltbListarProdutos.Name = "ltbListarProdutos";
            this.ltbListarProdutos.Size = new System.Drawing.Size(222, 144);
            this.ltbListarProdutos.TabIndex = 3;
            // 
            // lblListarNome
            // 
            this.lblListarNome.AutoSize = true;
            this.lblListarNome.Location = new System.Drawing.Point(34, 176);
            this.lblListarNome.Name = "lblListarNome";
            this.lblListarNome.Size = new System.Drawing.Size(92, 20);
            this.lblListarNome.TabIndex = 4;
            this.lblListarNome.Text = "Listar nome";
            // 
            // cbbListaNomes
            // 
            this.cbbListaNomes.FormattingEnabled = true;
            this.cbbListaNomes.Location = new System.Drawing.Point(34, 199);
            this.cbbListaNomes.Name = "cbbListaNomes";
            this.cbbListaNomes.Size = new System.Drawing.Size(166, 28);
            this.cbbListaNomes.TabIndex = 2;
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(34, 293);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(69, 24);
            this.ckbLivros.TabIndex = 4;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(34, 255);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(66, 20);
            this.lblEscolha.TabIndex = 7;
            this.lblEscolha.Text = "Escolha";
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Location = new System.Drawing.Point(34, 323);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(116, 24);
            this.ckbComputador.TabIndex = 5;
            this.ckbComputador.Text = "Computador";
            this.ckbComputador.UseVisualStyleBackColor = true;
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Location = new System.Drawing.Point(34, 353);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(67, 24);
            this.ckbMesa.TabIndex = 6;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Location = new System.Drawing.Point(33, 383);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(84, 24);
            this.ckbBanana.TabIndex = 7;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(245, 255);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(221, 151);
            this.pcbImagens.TabIndex = 8;
            this.pcbImagens.TabStop = false;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 479);
            this.Controls.Add(this.gpbComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.ComboBox cbbListaNomes;
        private System.Windows.Forms.Label lblListarNome;
        private System.Windows.Forms.ListBox ltbListarProdutos;
        private System.Windows.Forms.Label lblListarProdutos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pcbImagens;
    }
}