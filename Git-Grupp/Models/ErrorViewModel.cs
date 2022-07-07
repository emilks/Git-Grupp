namespace Git_Grupp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public int TestVariabel { get; set; }

        public int OkändVariabel { get; set; }

        public string ? Error { get; set; }

        public bool Sann { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}