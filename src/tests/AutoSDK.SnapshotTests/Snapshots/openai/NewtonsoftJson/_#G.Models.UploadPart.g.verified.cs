//HintName: G.Models.UploadPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The upload Part represents a chunk of bytes we can add to an Upload object.
    /// </summary>
    public sealed partial class UploadPart
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the Part was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The upload Part unique identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `upload.part`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UploadPartObject Object { get; set; }

        /// <summary>
        /// The ID of the Upload object that this Part was added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadPart" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the Part was created.
        /// </param>
        /// <param name="id">
        /// The upload Part unique identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `upload.part`.
        /// </param>
        /// <param name="uploadId">
        /// The ID of the Upload object that this Part was added to.
        /// </param>
        public UploadPart(
            global::System.DateTimeOffset createdAt,
            string id,
            string uploadId,
            global::G.UploadPartObject @object)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadPart" /> class.
        /// </summary>
        public UploadPart()
        {
        }
    }
}