using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string toolTipInserir { get; }

        public abstract string toolTipEditar { get; }

        public abstract string toolTipExcluir { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract UserControl ObterLista();

        public abstract string ObterTipoRegistro();

        public abstract void Excluir();
    }
}
