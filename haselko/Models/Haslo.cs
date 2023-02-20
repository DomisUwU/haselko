using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace haselko.Models
{
    public class Haslo
    {
        [DisplayName("Podaj ilosc znakow")]
        [DataType(DataType.Currency)]
        public double DlugoscHasla { get; set; }

        [DisplayName("Dodatki: ")]
        public List<Dodatki> Znaki { get; set; }
    }
}
