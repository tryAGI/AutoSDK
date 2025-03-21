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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The upload Part unique identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `upload.part`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UploadPartObjectJsonConverter))]
        public global::G.UploadPartObject Object { get; set; }

        /// <summary>
        /// The ID of the Upload object that this Part was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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