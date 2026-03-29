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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// HTTP method to use for upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public string Method { get; set; } = default!;

        /// <summary>
        /// Additional fields required for the upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Fields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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