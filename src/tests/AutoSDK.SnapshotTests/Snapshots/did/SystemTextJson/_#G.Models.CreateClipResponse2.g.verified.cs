//HintName: G.Models.CreateClipResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipResponse2
    {
        /// <summary>
        /// The ID of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An identifier of this clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipResponseObject2JsonConverter))]
        public global::G.CreateClipResponseObject2 Object { get; set; }

        /// <summary>
        /// Clip creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The status of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipResponseStatus2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateClipResponseStatus2 Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipResponse2" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the clip
        /// </param>
        /// <param name="createdAt">
        /// Clip creation time as iso-8601 string
        /// </param>
        /// <param name="status">
        /// The status of the clip
        /// </param>
        /// <param name="object">
        /// An identifier of this clip
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipResponse2(
            string id,
            string createdAt,
            global::G.CreateClipResponseStatus2 status,
            global::G.CreateClipResponseObject2 @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipResponse2" /> class.
        /// </summary>
        public CreateClipResponse2()
        {
        }
    }
}