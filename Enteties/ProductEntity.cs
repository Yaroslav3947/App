using System.ComponentModel.DataAnnotations;

namespace App.Enteties {
    public class ProductEntity {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UdpatedAt { get; set; } = DateTime.Now;
    }
}
