using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercadona.Models
{
    public class Categorie
    {
        public int id {  get; set; }
        public string? nom { get; set; }
    }
}
