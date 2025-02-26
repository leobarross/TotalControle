using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalControle.Dados.Classes
{
    public class Categoria
    {
        public Categoria()
        {
            Id = Guid.NewGuid().ToString();
            
        }

        public string Id { get; set; }
        public string Nome { get; set; }
    }
}
