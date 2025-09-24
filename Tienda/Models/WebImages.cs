using System.ComponentModel.DataAnnotations;


namespace Tienda.Models
{
    public class WebImages
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public byte[] Picture { get; set; }
    }
}
