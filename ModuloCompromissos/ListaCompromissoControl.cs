using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloCompromissos
{
    public partial class ListaCompromissoControl : UserControl
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        public ListaCompromissoControl()
        {
            InitializeComponent();

            DateOnly data = DateOnly.Parse("17/05/2023");

            TimeOnly horaInicio = TimeOnly.Parse("07:00:00");

            TimeOnly horaTermino = TimeOnly.Parse("10:00:00");

            compromissos.Add(new Compromisso(1, "Estudo", "Escola", "João", data, horaInicio, horaTermino));

            foreach (Compromisso c in compromissos)
            {
                listCompromisso.Items.Add(c);
            }
        }
    }
}
