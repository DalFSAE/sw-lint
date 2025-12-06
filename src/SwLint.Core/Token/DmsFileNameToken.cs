using System;


namespace SwLint.Core.Token
{
    // Example: DMS-27-CH-FRAME-P-000-COMMENT.file
    public class DmsFileNameToken
    {
        public string Prefix { get; set; } = "";
        public string Year { get; set; } = "";
        public string System { get; set; } = "";
        public string Project { get; set; } = "";
        public string Type { get; set; } = "";
        public string ID { get; set; } = "";
        public string? Comment { get; set; } = "";

        public bool IsValid =>
            !string.IsNullOrWhiteSpace(Prefix) &&
            !string.IsNullOrWhiteSpace(Year) &&
            !string.IsNullOrWhiteSpace(System) &&
            !string.IsNullOrWhiteSpace(Comment) &&
            !string.IsNullOrWhiteSpace(Type) &&
            !string.IsNullOrWhiteSpace(ID);

    }
}
