namespace ShiftAPI.Models
{
    public class ShiftItem
    {
        public long Id { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string? employee { get; set; }
    }
}