using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models
{
    public class Negotiation
    {
        public int NegotiationID { get; set; }
        public int ProductID { get; set; }
        [DisplayName("Proponowana cena")]
        [Range(0, double.MaxValue, ErrorMessage = "Proponowoana cena nie może być niższa niż 0.")]
        public decimal ProposedPrice { get; set; }

        public decimal AcceptedPrice { get; set; }
        public int AttemptCount { get; set; }  
        public bool IsAutomaticallyRejected { get; set; }
    }
}
