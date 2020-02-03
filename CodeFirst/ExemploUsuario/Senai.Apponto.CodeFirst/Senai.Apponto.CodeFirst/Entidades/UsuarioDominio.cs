using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Apponto.CodeFirst.Entidades
{
    [Table("Usuarios")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Usuario", TypeName = "varchar(150)")]
        public string Nome { get; set; }

        [Required]
        [Column("Email", TypeName = "varchar(150)")]
        public string Email { get; set; }

        [Required]
        [Column("Senha", TypeName = "varchar(20)")]
        public string Senha { get; set; }

    }
}
