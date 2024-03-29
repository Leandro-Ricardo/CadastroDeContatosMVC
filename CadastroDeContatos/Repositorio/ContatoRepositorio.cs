﻿using CadastroDeContatos.Data;
using CadastroDeContatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no banco de dados

            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }


    }
}
