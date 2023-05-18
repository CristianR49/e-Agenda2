﻿using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    public class Compromisso : EntidadeBase
    {
        public int id;
        public string assunto;
        public string local;
        public string contato;
        public DateOnly dataCompromisso;
        public TimeOnly horaInicio;
        public TimeOnly horaTermino;

        public Compromisso(string assunto, string local, string contato, DateOnly dataCompromisso, TimeOnly horaInicio, TimeOnly horaTermino)
        {
            this.assunto = assunto;
            this.local = local;
            this.contato = contato;
            this.dataCompromisso = dataCompromisso;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }

        public override string ToString()
        {
            return $"id: {id} Assunto: {assunto} Local: {local} Contato: {contato} Data do compromisso: {dataCompromisso} Hora de início: {horaInicio} Hora do término: {horaTermino}";
        }
    }
}
