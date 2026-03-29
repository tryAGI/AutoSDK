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
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_sign_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PreSignUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartMultipartUploadResponse" /> class.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="preSignUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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