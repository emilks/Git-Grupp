namespace Git_Grupp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public int TestVariabel { get; set; }

        public int �k�ndVariabel { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}