//HintName: G.Models.GetObjectDownloadURLResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetObjectDownloadURLResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlExpireAt")]
        public global::System.DateTime? UrlExpireAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public global::G.AIObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectDownloadURLResponse" /> class.
        /// </summary>
        /// <param name="downloadUrl"></param>
        /// <param name="urlExpireAt"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObjectDownloadURLResponse(
            string? downloadUrl,
            global::System.DateTime? urlExpireAt,
            global::G.AIObject? @object)
        {
            this.DownloadUrl = downloadUrl;
            this.UrlExpireAt = urlExpireAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectDownloadURLResponse" /> class.
        /// </summary>
        public GetObjectDownloadURLResponse()
        {
        }
    }
}