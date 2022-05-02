using eAgendaAtualizada2.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace eAgendaAtualizada2.Infra.Arquivos
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {

        private readonly ISerializadorContatos serializador;
        List<Contato> contatos;
        private int contador = 0;

        public RepositorioContatoEmArquivo(ISerializadorContatos serializador)
        {
            this.serializador = serializador;

            contatos = serializador.CarregarContatosDoArquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novaContato)
        {
            novaContato.Numero = ++contador;
            contatos.Add(novaContato);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    break;
                }
            }

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void AdicionarItens(Contato contatoSelecionada, List<ItemContato> itens)
        {
            foreach (var item in itens)
            {
                contatoSelecionada.AdicionarItem(item);
            }

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void AtualizarItens(Contato contatoSelecionada,
            List<ItemContato> itensConcluidos, List<ItemContato> itensPendentes)
        {
            serializador.GravarContatosEmArquivo(contatos);
        }
    }
}