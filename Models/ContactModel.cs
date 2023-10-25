using System.ComponentModel.DataAnnotations;

namespace MVCPracticaArqdSoft.Models {
    public class ContactModel {

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo del nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo del número telefonico es obligatorio")]
        public string PhoneNumber { get; set; }

        public string? Email { get; set; }

        [Required(ErrorMessage = "El campo de la clave es obligatorio")]
        public string Password { get; set; }
    }
}
