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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Presigned URLs for uploading parts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MultipartUploadPartUrl> PartUrls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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