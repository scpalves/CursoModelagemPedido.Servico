using CursoModelagemPedido.Servico.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoModelagemPedido.Servico.Services
{
    public class CategoriaRepository
    {


        public List<Categoria> listarContactos()
        {
            Categoria cat1 = new Categoria(1, "Informática");
            Categoria cat2 = new Categoria(2, "Escritório");
            List<Categoria> lista = new List<Categoria>();
            lista.Add(cat1);
            lista.Add(cat2);
            return lista;
        }
        

    }
}