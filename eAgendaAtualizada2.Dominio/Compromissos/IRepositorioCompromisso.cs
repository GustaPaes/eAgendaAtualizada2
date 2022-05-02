using System.Collections.Generic;

namespace eAgendaAtualizada2.Dominio
{
    public interface IRepositorioCompromisso
    {
        void AdicionarItens(Compromisso compromissoSelecionada, List<ItemCompromisso> itens);
        void AtualizarItens(Compromisso compromissoSelecionada, List<ItemCompromisso> itensConcluidos, List<ItemCompromisso> itensPendentes);
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        void Inserir(Compromisso novoCompromisso);
        List<Compromisso> SelecionarTodos();

    }
}