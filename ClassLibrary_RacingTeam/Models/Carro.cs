using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_RacingTeam.Models
{
    public class Carro
    {
        [Key] // Define a propriedade Id como chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Define a propriedade Id como gerada pelo banco de dados
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Categoria { get; set; }
    }
}
