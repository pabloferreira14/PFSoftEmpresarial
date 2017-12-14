namespace Apresentacao
{
    partial class FrmContato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContato));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMeusBoletos = new System.Windows.Forms.Label();
            this.gridBoletos = new System.Windows.Forms.DataGridView();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoLiberacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.btnAbrirBoleto = new System.Windows.Forms.Button();
            this.btnAutenticarLocal = new System.Windows.Forms.Button();
            this.btnAutenticar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(238, 391);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(138, 23);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMeusBoletos
            // 
            this.lblMeusBoletos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMeusBoletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeusBoletos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusBoletos.ForeColor = System.Drawing.Color.Red;
            this.lblMeusBoletos.Location = new System.Drawing.Point(12, 191);
            this.lblMeusBoletos.Name = "lblMeusBoletos";
            this.lblMeusBoletos.Size = new System.Drawing.Size(493, 22);
            this.lblMeusBoletos.TabIndex = 28;
            this.lblMeusBoletos.Text = "MEUS BOLETOS";
            this.lblMeusBoletos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridBoletos
            // 
            this.gridBoletos.AllowUserToAddRows = false;
            this.gridBoletos.AllowUserToDeleteRows = false;
            this.gridBoletos.AllowUserToResizeColumns = false;
            this.gridBoletos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridBoletos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridBoletos.ColumnHeadersHeight = 22;
            this.gridBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vencimento,
            this.Documento,
            this.Valor,
            this.Situacao,
            this.URL});
            this.gridBoletos.Location = new System.Drawing.Point(12, 211);
            this.gridBoletos.MultiSelect = false;
            this.gridBoletos.Name = "gridBoletos";
            this.gridBoletos.ReadOnly = true;
            this.gridBoletos.RowHeadersWidth = 40;
            this.gridBoletos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBoletos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBoletos.Size = new System.Drawing.Size(493, 172);
            this.gridBoletos.TabIndex = 29;
            // 
            // Vencimento
            // 
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 110;
            // 
            // Valor
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 110;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 106;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Codigo de Liberação";
            // 
            // txtCodigoLiberacao
            // 
            this.txtCodigoLiberacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLiberacao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLiberacao.Location = new System.Drawing.Point(12, 151);
            this.txtCodigoLiberacao.Name = "txtCodigoLiberacao";
            this.txtCodigoLiberacao.Size = new System.Drawing.Size(348, 27);
            this.txtCodigoLiberacao.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Meu CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(12, 98);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(348, 27);
            this.txtCNPJ.TabIndex = 23;
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetalhes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhes.ForeColor = System.Drawing.Color.Black;
            this.lblDetalhes.Location = new System.Drawing.Point(12, 9);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(493, 66);
            this.lblDetalhes.TabIndex = 21;
            this.lblDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbrirBoleto
            // 
            this.btnAbrirBoleto.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirBoleto.Image")));
            this.btnAbrirBoleto.Location = new System.Drawing.Point(12, 389);
            this.btnAbrirBoleto.Name = "btnAbrirBoleto";
            this.btnAbrirBoleto.Size = new System.Drawing.Size(142, 35);
            this.btnAbrirBoleto.TabIndex = 30;
            this.btnAbrirBoleto.Text = "Abrir Boleto [ F5 ]";
            this.btnAbrirBoleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirBoleto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirBoleto.UseVisualStyleBackColor = true;
            // 
            // btnAutenticarLocal
            // 
            this.btnAutenticarLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnAutenticarLocal.Image")));
            this.btnAutenticarLocal.Location = new System.Drawing.Point(363, 149);
            this.btnAutenticarLocal.Name = "btnAutenticarLocal";
            this.btnAutenticarLocal.Size = new System.Drawing.Size(142, 30);
            this.btnAutenticarLocal.TabIndex = 25;
            this.btnAutenticarLocal.Text = "Autenticar off-line";
            this.btnAutenticarLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutenticarLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutenticarLocal.UseVisualStyleBackColor = true;
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Image = ((System.Drawing.Image)(resources.GetObject("btnAutenticar.Image")));
            this.btnAutenticar.Location = new System.Drawing.Point(363, 96);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(142, 30);
            this.btnAutenticar.TabIndex = 22;
            this.btnAutenticar.Text = "Autenticar on-line";
            this.btnAutenticar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutenticar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutenticar.UseVisualStyleBackColor = true;
            // 
            // FrmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 437);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMeusBoletos);
            this.Controls.Add(this.btnAbrirBoleto);
            this.Controls.Add(this.gridBoletos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoLiberacao);
            this.Controls.Add(this.btnAutenticarLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.lblDetalhes);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMeusBoletos;
        private System.Windows.Forms.Button btnAbrirBoleto;
        private System.Windows.Forms.DataGridView gridBoletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoLiberacao;
        private System.Windows.Forms.Button btnAutenticarLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.Label lblDetalhes;
    }
}