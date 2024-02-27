namespace Exercicio1.pds_2024
{
    public partial class Form1 : Form

    {
        List<Empresa> A = new List<Empresa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Cnpj = mask_cnpj.Text;
            empresa.RazaoSocial = tx_razaosocial.Text;
            empresa.NomeFantasia = tx_nomeFantasia.Text;
            empresa.SituacaoCad = cb_situacaoCad.Text;
            empresa.DataInicio = Convert.ToDateTime(data_inicio.Text);
            empresa.Telefone = mask_telefone.Text;
            empresa.CPFpropri = mask_cpf.Text;
            empresa.CapitalSocial = Convert.ToInt32(tx_capitalSocial.Text);
            empresa.Endere�o = cb_endereco.Text;
            empresa.NaturezaJuri = cb_natuJuri.Text;
            empresa.NomePropri = tx_nomePropri.Text;


            if(rd_simplesNac.Checked)
            {
                empresa.RegimeTribu = rd_simplesNac.Text;
            }
            else if(rd_presumidoReal.Checked)
            {
                empresa.RegimeTribu = rd_presumidoReal.Text;
            }

            if(rd_grande.Checked)
            {
                empresa.PorteEmpre = rd_grande.Text;
            }
            else if (rd_medio.Checked)
            {
                empresa.PorteEmpre = rd_medio.Text;
            }
            else if (rd_grande.Checked)
            {
                empresa.PorteEmpre = rd_grande.Text;
            }

            if(rd_matriz.Checked)
            {
                empresa.Tipo = rd_matriz.Text;
            }
            else if (rd_filial.Checked)
            {
                empresa.Tipo = rd_filial.Text;
            }

            A.Add(empresa);

            MessageBox.Show($"CNPJ: {empresa.Cnpj} Raz�o Social:{empresa.RazaoSocial} Nome Fantasia: {empresa.NomeFantasia} Situa��o Cadastral {empresa.SituacaoCad}" +
                $"Data in�cio: {empresa.DataInicio} Telefone: {empresa.Telefone} CPF Propriet�rio: {empresa.CPFpropri} " +
                $"Capital Social: {empresa.CapitalSocial} Endere�o: {empresa.Endere�o} Natureza Jur�dica: {empresa.NaturezaJuri}" +
                $"Nome Propriet�rio: {empresa.NomePropri} Regime Tribut�rio: {empresa.RegimeTribu} Porte da Empresa: {empresa.PorteEmpre} Tipo: {empresa.Tipo}");


        }
    }
}