using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    public class PacoteDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPacote { get; set; }

        [Required]
        [Column("Titulo" ,TypeName = "VARCHAR(128)")]
        public string Titulo { get; set; }

        [Column("Imagem",TypeName = "TEXT")]
        public string Imagem { get; set; }

        [Required]
        [Column("Descrição",TypeName = "TEXT")]
        public string Descricao { get; set; }

        [Required]
        [Column("DateTime", TypeName = "DATETIME2")]
        public DateTime DataInicial { get; set; }

        [Required]
        [Column("DataFinal", TypeName = "DATETIME2")]
        public DateTime DataFinal { get; set; }

        [Required]
        [Column("Pais", TypeName = "VARCHAR(128)")]
        public string País { get; set; }

        [Required]
        [Column ("Ativo", TypeName = "bit")]
        public bool Ativo { get; set; }

        [Required]
        [Column("Oferta", TypeName = "bit")]
        public bool Oferta { get; set; }

        public PacoteDominio()
        {
            Ativo = true;
            Oferta = false;
        }
    }
}