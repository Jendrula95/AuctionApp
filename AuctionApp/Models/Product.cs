using System.ComponentModel.DataAnnotations;
using System.ComponentModel;




namespace AuctionApp.Models
{
    public class Product 
    {
      
        public int ProductID { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "Prosze podać nazwę produktu.")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Opis")]
        [Required(ErrorMessage = "Prosze podać opis.")]
        public string Description { get; set; }
        [DisplayName("Cena")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Prosze podać dodatnią cenę.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Kategoria")]
        [Required(ErrorMessage = "Prosze określić kategorię.")]
        public string Category { get; set; }

  

       

    }
}
