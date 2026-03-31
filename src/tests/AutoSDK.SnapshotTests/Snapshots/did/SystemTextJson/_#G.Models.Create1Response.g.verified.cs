//HintName: G.Models.Create1Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Create1Response
    {
        /// <summary>
        /// The ID of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Create1ResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Create1ResponseStatus Status { get; set; }

        /// <summary>
        /// An identifier of this avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Create1ResponseObjectJsonConverter))]
        public global::G.Create1ResponseObject Object { get; set; }

        /// <summary>
        /// Avatar creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create1Response" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the avatar
        /// </param>
        /// <param name="status">
        /// The status of the avatar
        /// </param>
        /// <param name="createdAt">
        /// Avatar creation time as iso-8601 string
        /// </param>
        /// <param name="object">
        /// An identifier of this avatar
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Create1Response(
            string id,
            global::G.Create1ResponseStatus status,
            string createdAt,
            global::G.Create1ResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create1Response" /> class.
        /// </summary>
        public Create1Response()
        {
        }
    }
}