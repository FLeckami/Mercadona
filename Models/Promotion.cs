using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mercadona.Models
{
    public class Promotion
    {
        public int id { get; set; }

        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime datedebut { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime datefin { get; set; }
        public int pctpromotion { get; set; }
    }
}
