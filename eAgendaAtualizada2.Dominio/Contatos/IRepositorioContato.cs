using System.Collections.Generic;

namespace eAgendaAtualizada2.Dominio
{
    public interface IRepositorioContato
    {
        void AdicionarItens(Contato contatoSelecionada, List<ItemContato> itens);
        void AtualizarItens(Contato contatoSelecionada, List<ItemContato> itensConcluidos, List<ItemContato> itensPendentes);
        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato novoContato);
        List<Contato> SelecionarTodos();

    }
}