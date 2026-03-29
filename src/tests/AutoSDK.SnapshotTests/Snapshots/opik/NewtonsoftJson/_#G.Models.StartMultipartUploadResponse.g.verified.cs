//HintName: G.Models.StartMultipartUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartMultipartUploadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pre_sign_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PreSignUrls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartMultipartUploadResponse" /> class.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="preSignUrls"></param>
        public StartMultipartUploadResponse(
            string uploadId,
            global::System.Collections.Generic.IList<string> preSignUrls)
        {
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.PreSignUrls = preSignUrls ?? throw new global::System.ArgumentNullException(nameof(preSignUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartMultipartUploadResponse" /> class.
        /// </summary>
        public StartMultipartUploadResponse()
        {
        }
    }
}