﻿using eAgendaAtualizada2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgendaAtualizada2.Infra.Arquivos
{
    public interface ISerializadorTarefas
    {
        List<Tarefa> CarregarTarefasDoArquivo();
        void GravarTarefasEmArquivo(List<Tarefa> tarefas);
    }
}
