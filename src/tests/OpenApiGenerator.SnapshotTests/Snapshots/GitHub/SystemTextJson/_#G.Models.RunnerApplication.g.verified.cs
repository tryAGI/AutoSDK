//HintName: G.Models.RunnerApplication.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Runner Application
    /// </summary>
    public sealed partial class RunnerApplication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Architecture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// A short lived bearer token used to download the runner, if needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_download_token")]
        public string? TempDownloadToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256_checksum")]
        public string? Sha256Checksum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}