using e_Agenda.Compartilhado;
using e_Agenda.ModuloCompromissos;

namespace e_Agenda
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();
        public TelaPrincipalForm()
        {
            InitializeComponent();

            repositorioCompromisso.PopularRegistrosAutomaticamente();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorCompromisso(repositorioCompromisso);

            ConfigurarTelaPrincipal(controlador);

        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            LabelTipoCadastro.Text = controladorBase.ObterTipoRegistro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl lista = controladorBase.ObterLista();

            panelRegistros.Controls.Clear();

            lista.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(lista);
        }

        private void ConfigurarToolTips(ControladorBase controladorBase)
        {
            btnInserir.ToolTipText = controladorBase.toolTipInserir;
            btnEditar.ToolTipText = controladorBase.toolTipEditar;
            btnExcluir.ToolTipText = controladorBase.toolTipExcluir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
    }
}