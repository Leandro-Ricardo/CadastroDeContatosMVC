using CadastroDeContatos.Models;
using System.Collections.Generic;

namespace CadastroDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
