using CursoModelagemPedido.Servico.Models;
using CursoModelagemPedido.Servico.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CursoModelagemPedido.Servico.Controllers
{
    public class CategoriaController : ApiController
    {
         private CategoriaRepository categoriaRepository;

         public CategoriaController()
        {
            this.categoriaRepository = new CategoriaRepository();
        }
        public List<Categoria> Get()
        {
            return categoriaRepository.listarContactos();
        }

    }
}
