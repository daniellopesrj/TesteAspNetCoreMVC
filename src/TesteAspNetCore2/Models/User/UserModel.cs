using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TesteAspNetCore2.Models.User
{
    public class UserModel
    {
        [Required]
        [Key]
        public int Id { get; set; }

        //[Required(AllowEmptyStrings = false,ErrorMessage = "O campo Login é obrigatório.",ErrorMessageResourceName ="UserModel",ErrorMessageResourceType = null)]
        [Required(ErrorMessage ="O campo Login é obrigatório.")]
        [Display(Name = "Login")]
        [DataType(DataType.Text)]
        [MaxLength(20)]
        public string Login { get; set; }

        [Required(ErrorMessage ="O campo senha é obrigatório.")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MaxLength(10)]
        public string Password { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [Display(Name ="Nome")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatório.")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        /*
        [Display(Name = "Endereço")]
        [MaxLength(100)]
        public string Address { get; set; }
        */
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get { return DateTime.Now; } }
        

    }
}
