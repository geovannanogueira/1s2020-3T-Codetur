using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Apponto.CodeFirst.Entidades
{
    [Table("Historicos")]
    public class HistoricoDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("IdUsuario", TypeName = "int")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual UsuarioDominio Usuario { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataHora { get; set; }
  
    }
}
