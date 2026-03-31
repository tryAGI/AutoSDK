//HintName: G.Models.S3UploadParamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for direct upload to S3 storage
    /// </summary>
    public sealed partial class S3UploadParamsResponse
    {
        /// <summary>
        /// Pre-signed URL for upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// HTTP method to use for upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// Additional fields required for the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S3UploadParamsResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Pre-signed URL for upload
        /// </param>
        /// <param name="method">
        /// HTTP method to use for upload
        /// </param>
        /// <param name="fields">
        /// Additional fields required for the upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S3UploadParamsResponse(
            string url,
            string method,
            global::System.Collections.Generic.Dictionary<string, string> fields)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3UploadParamsResponse" /> class.
        /// </summary>
        public S3UploadParamsResponse()
        {
        }
    }
}