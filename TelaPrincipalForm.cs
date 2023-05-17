using e_Agenda.ModuloCompromissos;

namespace e_Agenda
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            LabelTipoCadastro.Text = "Cadastro de Compromissos";
            ListaCompromissoControl listaCompromissoControl = new ListaCompromissoControl();
            panelRegistros.Controls.Clear();
            listaCompromissoControl.Dock = DockStyle.Fill;
            panelRegistros.Controls.Add(listaCompromissoControl);
        }
    }
}