//HintName: G.Models.MultipartUploadListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadListResponse
    {
        /// <summary>
        /// List of in-progress multipart uploads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MultipartUploadObject> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of in-progress multipart uploads
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartUploadListResponse(
            global::System.Collections.Generic.IList<global::G.MultipartUploadObject> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadListResponse" /> class.
        /// </summary>
        public MultipartUploadListResponse()
        {
        }
    }
}