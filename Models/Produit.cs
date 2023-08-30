using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mercadona.Models
{
    public class Produit
    {
        public int id { get; set; }
        public string? titre { get; set; }
        public string? description { get; set; }
        public float? prix { get; set; }
        public string? image { get; set; }
        public int prd_ctg_id { get; set; }
        public int? prd_prm_id { get; set; }

        public virtual Categorie? Categorie { get; set; }
        public virtual Promotion? Promotion { get; set; }
    }
}
