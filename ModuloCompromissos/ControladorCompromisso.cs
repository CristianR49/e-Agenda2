using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private ListaCompromissoControl listaCompromissoControl;
        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso) 
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }
        public override string toolTipInserir { get { return "Inserir um novo Compromisso"; } }

        public override string toolTipEditar { get { return "Editar um Compromisso existente"; } }

        public override string toolTipExcluir { get { return "Excluir um compromisso Compromisso existente"; } }
        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                MessageBox.Show("Informações gravadas");

                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }
        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            telaCompromisso.Compromisso = listaCompromissoControl.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                MessageBox.Show("Informações Editadas");

                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Editar(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {

            Compromisso compromisso = listaCompromissoControl.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Compromisso {compromisso.assunto}?", "Exclusão de compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {

                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listaCompromissoControl.AtualizarRegistros(compromissos);
        }


        public override UserControl ObterLista()
        {
            if (listaCompromissoControl == null)
                listaCompromissoControl = new ListaCompromissoControl();

            CarregarCompromissos();

            return listaCompromissoControl;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Compromissos";
        }

    }
}
