using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_RacingTeam.Models
{
    public class Circuito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        #region ctor
        public Circuito() { }
        public Circuito(string nome)
        {
            Nome = nome;
        }
        #endregion
    }
}
