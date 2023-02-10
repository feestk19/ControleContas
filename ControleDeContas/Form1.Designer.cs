
namespace ControleDeContas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.nOMECONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTVALCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPAGCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSCONTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleContasBD = new ControleDeContas.ControleContasBD();
            this.cONTASTableAdapter = new ControleDeContas.ControleContasBDTableAdapters.CONTASTableAdapter();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.rdbAlfabetica = new System.Windows.Forms.RadioButton();
            this.rdbValor = new System.Windows.Forms.RadioButton();
            this.rdbDataVencimento = new System.Windows.Forms.RadioButton();
            this.rdbDataPagamento = new System.Windows.Forms.RadioButton();
            this.txtNomeConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleContasBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Contas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridPrincipal
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "Sem dados";
            this.gridPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPrincipal.AutoGenerateColumns = false;
            this.gridPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrincipal.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.gridPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Sem dados";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMECONTADataGridViewTextBoxColumn,
            this.dESCRICAOCONTADataGridViewTextBoxColumn,
            this.vALORCONTADataGridViewTextBoxColumn,
            this.tIPOCONTADataGridViewTextBoxColumn,
            this.dTVALCONTADataGridViewTextBoxColumn,
            this.dTPAGCONTADataGridViewTextBoxColumn,
            this.sTATUSCONTADataGridViewTextBoxColumn});
            this.gridPrincipal.DataSource = this.cONTASBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPrincipal.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPrincipal.Location = new System.Drawing.Point(43, 240);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.Size = new System.Drawing.Size(1068, 457);
            this.gridPrincipal.TabIndex = 1;
            // 
            // nOMECONTADataGridViewTextBoxColumn
            // 
            this.nOMECONTADataGridViewTextBoxColumn.DataPropertyName = "NOMECONTA";
            this.nOMECONTADataGridViewTextBoxColumn.HeaderText = "NOME DA CONTA";
            this.nOMECONTADataGridViewTextBoxColumn.Name = "nOMECONTADataGridViewTextBoxColumn";
            this.nOMECONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRICAOCONTADataGridViewTextBoxColumn
            // 
            this.dESCRICAOCONTADataGridViewTextBoxColumn.DataPropertyName = "DESCRICAOCONTA";
            this.dESCRICAOCONTADataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO";
            this.dESCRICAOCONTADataGridViewTextBoxColumn.Name = "dESCRICAOCONTADataGridViewTextBoxColumn";
            this.dESCRICAOCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORCONTADataGridViewTextBoxColumn
            // 
            this.vALORCONTADataGridViewTextBoxColumn.DataPropertyName = "VALORCONTA";
            this.vALORCONTADataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORCONTADataGridViewTextBoxColumn.Name = "vALORCONTADataGridViewTextBoxColumn";
            this.vALORCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOCONTADataGridViewTextBoxColumn
            // 
            this.tIPOCONTADataGridViewTextBoxColumn.DataPropertyName = "TIPOCONTA";
            this.tIPOCONTADataGridViewTextBoxColumn.HeaderText = "TIPO DA CONTA";
            this.tIPOCONTADataGridViewTextBoxColumn.Name = "tIPOCONTADataGridViewTextBoxColumn";
            this.tIPOCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTVALCONTADataGridViewTextBoxColumn
            // 
            this.dTVALCONTADataGridViewTextBoxColumn.DataPropertyName = "DTVALCONTA";
            this.dTVALCONTADataGridViewTextBoxColumn.HeaderText = "DATA DE VENCIMENTO";
            this.dTVALCONTADataGridViewTextBoxColumn.Name = "dTVALCONTADataGridViewTextBoxColumn";
            this.dTVALCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTPAGCONTADataGridViewTextBoxColumn
            // 
            this.dTPAGCONTADataGridViewTextBoxColumn.DataPropertyName = "DTPAGCONTA";
            this.dTPAGCONTADataGridViewTextBoxColumn.HeaderText = "DATA DO PAGAMENTO";
            this.dTPAGCONTADataGridViewTextBoxColumn.Name = "dTPAGCONTADataGridViewTextBoxColumn";
            this.dTPAGCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUSCONTADataGridViewTextBoxColumn
            // 
            this.sTATUSCONTADataGridViewTextBoxColumn.DataPropertyName = "STATUSCONTA";
            this.sTATUSCONTADataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSCONTADataGridViewTextBoxColumn.Name = "sTATUSCONTADataGridViewTextBoxColumn";
            this.sTATUSCONTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONTASBindingSource
            // 
            this.cONTASBindingSource.DataMember = "CONTAS";
            this.cONTASBindingSource.DataSource = this.controleContasBD;
            // 
            // controleContasBD
            // 
            this.controleContasBD.DataSetName = "ControleContasBD";
            this.controleContasBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTASTableAdapter
            // 
            this.cONTASTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(43, 757);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(232, 81);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Conta";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(322, 757);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(232, 81);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar Conta";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(597, 757);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(232, 81);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar Conta";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(879, 757);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(232, 81);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Conta";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 702);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(112, 702);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "label3";
            // 
            // tmHora
            // 
            this.tmHora.Enabled = true;
            // 
            // rdbAlfabetica
            // 
            this.rdbAlfabetica.AutoSize = true;
            this.rdbAlfabetica.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlfabetica.Location = new System.Drawing.Point(169, 205);
            this.rdbAlfabetica.Name = "rdbAlfabetica";
            this.rdbAlfabetica.Size = new System.Drawing.Size(167, 26);
            this.rdbAlfabetica.TabIndex = 8;
            this.rdbAlfabetica.TabStop = true;
            this.rdbAlfabetica.Text = "Ordem Alfabética";
            this.rdbAlfabetica.UseVisualStyleBackColor = true;
            // 
            // rdbValor
            // 
            this.rdbValor.AutoSize = true;
            this.rdbValor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValor.Location = new System.Drawing.Point(791, 205);
            this.rdbValor.Name = "rdbValor";
            this.rdbValor.Size = new System.Drawing.Size(70, 26);
            this.rdbValor.TabIndex = 9;
            this.rdbValor.TabStop = true;
            this.rdbValor.Text = "Valor";
            this.rdbValor.UseVisualStyleBackColor = true;
            // 
            // rdbDataVencimento
            // 
            this.rdbDataVencimento.AutoSize = true;
            this.rdbDataVencimento.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDataVencimento.Location = new System.Drawing.Point(369, 205);
            this.rdbDataVencimento.Name = "rdbDataVencimento";
            this.rdbDataVencimento.Size = new System.Drawing.Size(188, 26);
            this.rdbDataVencimento.TabIndex = 10;
            this.rdbDataVencimento.TabStop = true;
            this.rdbDataVencimento.Text = "Data de Vencimento";
            this.rdbDataVencimento.UseVisualStyleBackColor = true;
            // 
            // rdbDataPagamento
            // 
            this.rdbDataPagamento.AutoSize = true;
            this.rdbDataPagamento.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDataPagamento.Location = new System.Drawing.Point(581, 205);
            this.rdbDataPagamento.Name = "rdbDataPagamento";
            this.rdbDataPagamento.Size = new System.Drawing.Size(183, 26);
            this.rdbDataPagamento.TabIndex = 11;
            this.rdbDataPagamento.TabStop = true;
            this.rdbDataPagamento.Text = "Data de Pagamento";
            this.rdbDataPagamento.UseVisualStyleBackColor = true;
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConta.Location = new System.Drawing.Point(43, 164);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Size = new System.Drawing.Size(1068, 26);
            this.txtNomeConta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Digite o nome da conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ordenar por:";
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.DataSource = this.cONTASBindingSource;
            this.cmbTipoConta.DisplayMember = "TIPOCONTA";
            this.cmbTipoConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoConta.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.ItemHeight = 22;
            this.cmbTipoConta.Location = new System.Drawing.Point(930, 202);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(166, 30);
            this.cmbTipoConta.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(877, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 860);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(410, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quarta-feira, 31 de dezembro de 9999 - 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1154, 891);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeConta);
            this.Controls.Add(this.rdbDataPagamento);
            this.Controls.Add(this.rdbDataVencimento);
            this.Controls.Add(this.rdbValor);
            this.Controls.Add(this.rdbAlfabetica);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gridPrincipal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 930);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1170, 930);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Contas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleContasBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPrincipal;
        private ControleContasBD controleContasBD;
        private System.Windows.Forms.BindingSource cONTASBindingSource;
        private ControleContasBDTableAdapters.CONTASTableAdapter cONTASTableAdapter;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTVALCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTPAGCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSCONTADataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer tmHora;
        private System.Windows.Forms.RadioButton rdbAlfabetica;
        private System.Windows.Forms.RadioButton rdbValor;
        private System.Windows.Forms.RadioButton rdbDataVencimento;
        private System.Windows.Forms.RadioButton rdbDataPagamento;
        private System.Windows.Forms.TextBox txtNomeConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

