using System.ComponentModel.DataAnnotations;

namespace _12626_Egzamin_ASP.Models
{
    public class oceny
    {
        public int Id { get; set; }
        public int NrIndeksu { get; set; }
        [Range (2,5, ErrorMessage = "Ocena musi byc pomiedzy 2 a 5.")]
        public int Ocena { get; set; }
        public string Przedmiot { get; set; }
    }
}
