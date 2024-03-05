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

// post -h Content-Type=application/json -c "{"start":"2024-03-02 15:45:30","end":"2024-03-02 15:45:30", "employee":"Shayne"}"
