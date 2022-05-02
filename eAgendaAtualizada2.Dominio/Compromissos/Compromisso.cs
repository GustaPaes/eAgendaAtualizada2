using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgendaAtualizada2.Dominio
{
    [Serializable]
    public class Compromisso
    {
        private List<ItemCompromisso> itens = new List<ItemCompromisso>();

        public Compromisso()
        {
            DataCadastro = DateTime.Now;
        }

        public Compromisso(string assunto, string local, string dataCompromisso, string horaInicio, string horaTermino, string contato) : this()
        {
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            Contato = contato;
            DataCadastro = null;
        }

        public List<ItemCompromisso> Itens { get { return itens; } }
        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public string DataCompromisso { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public string Contato { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero}, Assunto: {Assunto}, Local: {Local}, Data do compromisso: {DataCompromisso}, Hora de ínicio: {HoraInicio}, Hora de término: {HoraTermino}, Contato: {Contato}";
        }

        public void AdicionarItem(ItemCompromisso item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }
   

        //public override string Validar()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    if (string.IsNullOrEmpty(Assunto))
        //        sb.AppendLine("O assunto do compromisso é obrigatório!");

        //    if (string.IsNullOrEmpty(Local))
        //        sb.AppendLine("O local do compromisso é obrigatório!");

        //    if (DataCompromisso == DateTime.MinValue)
        //        sb.AppendLine("A data do compromisso obrigatória!");

        //    if (DataCompromisso < DateTime.Today)
        //        sb.AppendLine("A data do compromisso não pode ser antes de hoje!");

        //    if (HoraInicio > HoraTermino)
        //        sb.AppendLine("A hora de início não pode ser depois do término!");

        //    if (sb.Length == 0)
        //        sb.Append("REGISTRO_VALIDO");

        //    return sb.ToString();
        //}

    }
}
