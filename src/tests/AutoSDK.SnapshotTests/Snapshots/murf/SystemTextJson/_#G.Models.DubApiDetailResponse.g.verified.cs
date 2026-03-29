//HintName: G.Models.DubApiDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubApiDetailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_srt_url")]
        public string? DownloadSrtUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubApiDetailResponse" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="downloadSrtUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubApiDetailResponse(
            string? locale,
            string? status,
            string? errorMessage,
            string? downloadUrl,
            string? downloadSrtUrl)
        {
            this.Locale = locale;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.DownloadUrl = downloadUrl;
            this.DownloadSrtUrl = downloadSrtUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubApiDetailResponse" /> class.
        /// </summary>
        public DubApiDetailResponse()
        {
        }
    }
}