namespace Exercicio1.pds_2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.mask_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.tx_razaosocial = new System.Windows.Forms.TextBox();
            this.tx_nomePropri = new System.Windows.Forms.TextBox();
            this.tx_nomeFantasia = new System.Windows.Forms.TextBox();
            this.cb_situacaoCad = new System.Windows.Forms.ComboBox();
            this.rd_simplesNac = new System.Windows.Forms.RadioButton();
            this.rd_presumidoReal = new System.Windows.Forms.RadioButton();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.rd_matriz = new System.Windows.Forms.RadioButton();
            this.rd_pequeno = new System.Windows.Forms.RadioButton();
            this.rd_filial = new System.Windows.Forms.RadioButton();
            this.rd_grande = new System.Windows.Forms.RadioButton();
            this.rd_medio = new System.Windows.Forms.RadioButton();
            this.tx_capitalSocial = new System.Windows.Forms.TextBox();
            this.cb_endereco = new System.Windows.Forms.ComboBox();
            this.cb_natuJuri = new System.Windows.Forms.ComboBox();
            this.data_inicio = new System.Windows.Forms.DateTimePicker();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(459, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "regime tributário:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "situação cadastral:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "nome fantasia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "razão social:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(466, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "data de inicio de atividade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(472, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(472, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "capital social:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(472, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(472, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "natureza juridica:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(45, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 28);
            this.label12.TabIndex = 11;
            this.label12.Text = "porte da empresa:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(469, 680);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "endereço completo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(469, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 28);
            this.label14.TabIndex = 13;
            this.label14.Text = "nome do proprietario:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(472, 471);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 28);
            this.label15.TabIndex = 14;
            this.label15.Text = "cpf do proprietário:";
            // 
            // mask_cnpj
            // 
            this.mask_cnpj.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mask_cnpj.Location = new System.Drawing.Point(112, 137);
            this.mask_cnpj.Mask = " 99.999.999/9999-99";
            this.mask_cnpj.Name = "mask_cnpj";
            this.mask_cnpj.Size = new System.Drawing.Size(154, 35);
            this.mask_cnpj.TabIndex = 15;
            // 
            // tx_razaosocial
            // 
            this.tx_razaosocial.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tx_razaosocial.Location = new System.Drawing.Point(169, 197);
            this.tx_razaosocial.Name = "tx_razaosocial";
            this.tx_razaosocial.Size = new System.Drawing.Size(125, 35);
            this.tx_razaosocial.TabIndex = 16;
            // 
            // tx_nomePropri
            // 
            this.tx_nomePropri.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tx_nomePropri.Location = new System.Drawing.Point(634, 329);
            this.tx_nomePropri.Name = "tx_nomePropri";
            this.tx_nomePropri.Size = new System.Drawing.Size(220, 35);
            this.tx_nomePropri.TabIndex = 17;
            // 
            // tx_nomeFantasia
            // 
            this.tx_nomeFantasia.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tx_nomeFantasia.Location = new System.Drawing.Point(169, 244);
            this.tx_nomeFantasia.Name = "tx_nomeFantasia";
            this.tx_nomeFantasia.Size = new System.Drawing.Size(125, 35);
            this.tx_nomeFantasia.TabIndex = 18;
            // 
            // cb_situacaoCad
            // 
            this.cb_situacaoCad.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_situacaoCad.FormattingEnabled = true;
            this.cb_situacaoCad.Items.AddRange(new object[] {
            "ativa",
            "nula",
            "suspensa",
            "inapta",
            "baixada"});
            this.cb_situacaoCad.Location = new System.Drawing.Point(190, 304);
            this.cb_situacaoCad.Name = "cb_situacaoCad";
            this.cb_situacaoCad.Size = new System.Drawing.Size(151, 36);
            this.cb_situacaoCad.TabIndex = 19;
            // 
            // rd_simplesNac
            // 
            this.rd_simplesNac.AutoSize = true;
            this.rd_simplesNac.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_simplesNac.Location = new System.Drawing.Point(39, 436);
            this.rd_simplesNac.Name = "rd_simplesNac";
            this.rd_simplesNac.Size = new System.Drawing.Size(143, 32);
            this.rd_simplesNac.TabIndex = 20;
            this.rd_simplesNac.TabStop = true;
            this.rd_simplesNac.Text = "simples nacional";
            this.rd_simplesNac.UseVisualStyleBackColor = true;
            // 
            // rd_presumidoReal
            // 
            this.rd_presumidoReal.AutoSize = true;
            this.rd_presumidoReal.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_presumidoReal.Location = new System.Drawing.Point(39, 467);
            this.rd_presumidoReal.Name = "rd_presumidoReal";
            this.rd_presumidoReal.Size = new System.Drawing.Size(195, 32);
            this.rd_presumidoReal.TabIndex = 22;
            this.rd_presumidoReal.TabStop = true;
            this.rd_presumidoReal.Text = "lucro presumido ou real";
            this.rd_presumidoReal.UseVisualStyleBackColor = true;
            // 
            // mask_telefone
            // 
            this.mask_telefone.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mask_telefone.Location = new System.Drawing.Point(545, 541);
            this.mask_telefone.Mask = "(00) 0000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(117, 35);
            this.mask_telefone.TabIndex = 23;
            // 
            // mask_cpf
            // 
            this.mask_cpf.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mask_cpf.Location = new System.Drawing.Point(626, 471);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(125, 35);
            this.mask_cpf.TabIndex = 24;
            // 
            // rd_matriz
            // 
            this.rd_matriz.AutoSize = true;
            this.rd_matriz.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_matriz.Location = new System.Drawing.Point(477, 192);
            this.rd_matriz.Name = "rd_matriz";
            this.rd_matriz.Size = new System.Drawing.Size(76, 32);
            this.rd_matriz.TabIndex = 26;
            this.rd_matriz.TabStop = true;
            this.rd_matriz.Text = "matriz";
            this.rd_matriz.UseVisualStyleBackColor = true;
            // 
            // rd_pequeno
            // 
            this.rd_pequeno.AutoSize = true;
            this.rd_pequeno.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_pequeno.Location = new System.Drawing.Point(50, 585);
            this.rd_pequeno.Name = "rd_pequeno";
            this.rd_pequeno.Size = new System.Drawing.Size(89, 32);
            this.rd_pequeno.TabIndex = 27;
            this.rd_pequeno.TabStop = true;
            this.rd_pequeno.Text = "pequeno";
            this.rd_pequeno.UseVisualStyleBackColor = true;
            // 
            // rd_filial
            // 
            this.rd_filial.AutoSize = true;
            this.rd_filial.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_filial.Location = new System.Drawing.Point(575, 192);
            this.rd_filial.Name = "rd_filial";
            this.rd_filial.Size = new System.Drawing.Size(56, 32);
            this.rd_filial.TabIndex = 28;
            this.rd_filial.TabStop = true;
            this.rd_filial.Text = "filial";
            this.rd_filial.UseVisualStyleBackColor = true;
            // 
            // rd_grande
            // 
            this.rd_grande.AutoSize = true;
            this.rd_grande.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_grande.Location = new System.Drawing.Point(102, 630);
            this.rd_grande.Name = "rd_grande";
            this.rd_grande.Size = new System.Drawing.Size(80, 32);
            this.rd_grande.TabIndex = 29;
            this.rd_grande.TabStop = true;
            this.rd_grande.Text = "grande";
            this.rd_grande.UseVisualStyleBackColor = true;
            // 
            // rd_medio
            // 
            this.rd_medio.AutoSize = true;
            this.rd_medio.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_medio.Location = new System.Drawing.Point(161, 585);
            this.rd_medio.Name = "rd_medio";
            this.rd_medio.Size = new System.Drawing.Size(73, 32);
            this.rd_medio.TabIndex = 30;
            this.rd_medio.TabStop = true;
            this.rd_medio.Text = "médio";
            this.rd_medio.UseVisualStyleBackColor = true;
            // 
            // tx_capitalSocial
            // 
            this.tx_capitalSocial.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tx_capitalSocial.Location = new System.Drawing.Point(620, 603);
            this.tx_capitalSocial.Name = "tx_capitalSocial";
            this.tx_capitalSocial.Size = new System.Drawing.Size(125, 35);
            this.tx_capitalSocial.TabIndex = 31;
            // 
            // cb_endereco
            // 
            this.cb_endereco.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_endereco.FormattingEnabled = true;
            this.cb_endereco.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cb_endereco.Location = new System.Drawing.Point(620, 672);
            this.cb_endereco.Name = "cb_endereco";
            this.cb_endereco.Size = new System.Drawing.Size(151, 36);
            this.cb_endereco.TabIndex = 32;
            this.cb_endereco.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cb_natuJuri
            // 
            this.cb_natuJuri.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_natuJuri.FormattingEnabled = true;
            this.cb_natuJuri.Items.AddRange(new object[] {
            "EI- Empresário individual",
            "MEI- Microempeendedor Individual",
            "Sociedade Anônima"});
            this.cb_natuJuri.Location = new System.Drawing.Point(600, 265);
            this.cb_natuJuri.Name = "cb_natuJuri";
            this.cb_natuJuri.Size = new System.Drawing.Size(151, 36);
            this.cb_natuJuri.TabIndex = 33;
            // 
            // data_inicio
            // 
            this.data_inicio.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data_inicio.Location = new System.Drawing.Point(671, 397);
            this.data_inicio.Name = "data_inicio";
            this.data_inicio.Size = new System.Drawing.Size(302, 35);
            this.data_inicio.TabIndex = 34;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_salvar.Location = new System.Drawing.Point(931, 646);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(121, 62);
            this.bt_salvar.TabIndex = 35;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 784);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.data_inicio);
            this.Controls.Add(this.cb_natuJuri);
            this.Controls.Add(this.cb_endereco);
            this.Controls.Add(this.tx_capitalSocial);
            this.Controls.Add(this.rd_medio);
            this.Controls.Add(this.rd_grande);
            this.Controls.Add(this.rd_filial);
            this.Controls.Add(this.rd_pequeno);
            this.Controls.Add(this.rd_matriz);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.mask_telefone);
            this.Controls.Add(this.rd_presumidoReal);
            this.Controls.Add(this.rd_simplesNac);
            this.Controls.Add(this.cb_situacaoCad);
            this.Controls.Add(this.tx_nomeFantasia);
            this.Controls.Add(this.tx_nomePropri);
            this.Controls.Add(this.tx_razaosocial);
            this.Controls.Add(this.mask_cnpj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private MaskedTextBox mask_cnpj;
        private TextBox tx_razaosocial;
        private TextBox tx_nomePropri;
        private TextBox tx_nomeFantasia;
        private ComboBox cb_situacaoCad;
        private RadioButton rd_simplesNac;
        private RadioButton rd_presumidoReal;
        private MaskedTextBox mask_telefone;
        private MaskedTextBox mask_cpf;
        private RadioButton rd_matriz;
        private RadioButton rd_pequeno;
        private RadioButton rd_filial;
        private RadioButton rd_grande;
        private RadioButton rd_medio;
        private TextBox tx_capitalSocial;
        private ComboBox cb_endereco;
        private ComboBox cb_natuJuri;
        private DateTimePicker data_inicio;
        private Button bt_salvar;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}