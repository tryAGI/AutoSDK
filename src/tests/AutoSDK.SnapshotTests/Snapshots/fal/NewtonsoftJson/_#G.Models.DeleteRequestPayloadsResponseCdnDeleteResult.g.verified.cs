//HintName: G.Models.DeleteRequestPayloadsResponseCdnDeleteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of deleting a single CDN file
    /// </summary>
    public sealed partial class DeleteRequestPayloadsResponseCdnDeleteResult
    {
        /// <summary>
        /// CDN URL of the file that was targeted for deletion<br/>
        /// Example: https://v3.fal.media/files/example/output.png
        /// </summary>
        /// <example>https://v3.fal.media/files/example/output.png</example>
        [global::Newtonsoft.Json.JsonProperty("link", Required = global::Newtonsoft.Json.Required.Always)]
        public string Link { get; set; } = default!;

        /// <summary>
        /// Error message if deletion failed for this file, null if successful<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponseCdnDeleteResult" /> class.
        /// </summary>
        /// <param name="link">
        /// CDN URL of the file that was targeted for deletion<br/>
        /// Example: https://v3.fal.media/files/example/output.png
        /// </param>
        /// <param name="exception">
        /// Error message if deletion failed for this file, null if successful<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public DeleteRequestPayloadsResponseCdnDeleteResult(
            string link,
            string? exception)
        {
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
            this.Exception = exception;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponseCdnDeleteResult" /> class.
        /// </summary>
        public DeleteRequestPayloadsResponseCdnDeleteResult()
        {
        }
    }
}