using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoModelagemPedido.Servico.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Categoria(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

}