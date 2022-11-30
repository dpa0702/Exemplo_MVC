using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exemplo_MVC.Models
{
    [Table("Conta")]
    public class Conta
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descricao")]
        public string Description { get; set; }

    }
}
