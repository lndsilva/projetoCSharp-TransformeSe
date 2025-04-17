namespace ProjetoDataGridView
{
    partial class frmCarregaDataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregaDataGridView));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnCarregaGridView = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(10, 15);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(947, 338);
            this.dgvDados.TabIndex = 0;
            // 
            // btnCarregaGridView
            // 
            this.btnCarregaGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaGridView.Location = new System.Drawing.Point(10, 371);
            this.btnCarregaGridView.Name = "btnCarregaGridView";
            this.btnCarregaGridView.Size = new System.Drawing.Size(197, 58);
            this.btnCarregaGridView.TabIndex = 1;
            this.btnCarregaGridView.Text = "Carrega Grid View";
            this.btnCarregaGridView.UseVisualStyleBackColor = true;
            this.btnCarregaGridView.Click += new System.EventHandler(this.btnCarregaGridView_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(225, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(197, 58);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCarregaDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregaGridView);
            this.Controls.Add(this.dgvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarregaDataGridView";
            this.Text = "Carrega Data Grid View";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnCarregaGridView;
        private System.Windows.Forms.Button btnLimpar;
    }
}