using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_RacingTeam.Models
{
    public class Resultado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Resultado { get; set; }

        public int Id_Corrida { get; set; }
        public int Id_Piloto { get; set; }
        public int Posicao { get; set; }
        public string VoltaMaisRapida { get; set; }
        public ClassificacaoGeral ClassificacaoGeral { get; set; }
        public Piloto Piloto { get; set; }

        public Corrida Corrida { get; set; }

        #region ctor
        public Resultado() { }
        #endregion
    }
}
