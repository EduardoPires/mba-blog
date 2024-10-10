using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Blog.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [Display(Name = "Titulo")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [Display(Name = "Conte�do")]
        [StringLength(300, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string Content { get; set; }

        [Display(Name = "Data de Cria��o")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} n�o est� em formato incorreto")]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        public int AuthorId { get; set; }

        [Display(Name = "Autor")]
        public virtual IdentityUser Author { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = [];
    }
}