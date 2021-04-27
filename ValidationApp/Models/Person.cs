using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Введите имя!")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите почту!")]
        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль!")]
        [ScaffoldColumn(false)]
        [Display(Name="Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Введите возраст!")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
    }
}