using System.ComponentModel.DataAnnotations;

namespace DbConnector.Core
{
    public class Trade
    {
        [Key]
        public int Id { get; set; }
        public long Timestamp { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
        public string Side { get; set; }
    }
}
