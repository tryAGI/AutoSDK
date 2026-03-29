//HintName: G.Models.CreateMultipartUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMultipartUploadResponse
    {
        /// <summary>
        /// The multipart upload ID (use this to complete or abort)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Presigned URLs for uploading parts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MultipartUploadPartUrl> PartUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultipartUploadResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The multipart upload ID (use this to complete or abort)
        /// </param>
        /// <param name="partUrls">
        /// Presigned URLs for uploading parts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMultipartUploadResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPartUrl> partUrls)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PartUrls = partUrls ?? throw new global::System.ArgumentNullException(nameof(partUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultipartUploadResponse" /> class.
        /// </summary>
        public CreateMultipartUploadResponse()
        {
        }
    }
}