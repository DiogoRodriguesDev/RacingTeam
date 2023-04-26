using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_RacingTeam.Models
{
    public class Equipa
    {
        #region Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
        #endregion

        #region ctor
        public Equipa() { }
        public Equipa(string nome)
        {
            Nome = nome;
        }
        #endregion
    }
}
