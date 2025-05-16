namespace movieAPI.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string ChatRoomId { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
