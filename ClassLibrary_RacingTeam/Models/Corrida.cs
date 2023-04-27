using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_RacingTeam.Models
{
    public class Corrida
    {
        #region Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_corrida { get; set; }
        
        public DateTime Data { get; set; }
        public int Id_competicao { get; set; }
        public int Id_circuito { get; set; }

        public List<Carro> CarrosPermitidos { get; set; }

        [NotMapped]
        public List<TipoPneu> PneusPermitidos { get; set; }
        public int NumeroVoltas { get; set; }
        public int NumeroMinutos { get; set; }
        [ForeignKey("Id_Resultado")]
        public Resultado Resultado { get; set; }
        public Circuito Circuito { get; set; }
        #endregion

        #region Ctor
        public Corrida() { }
        public Corrida(DateTime data, int id_competicao, int id_circuito) 
        { 
            Data = data;
            Id_competicao = id_competicao;
            Id_circuito = id_circuito;
        }
        #endregion
    }
}
