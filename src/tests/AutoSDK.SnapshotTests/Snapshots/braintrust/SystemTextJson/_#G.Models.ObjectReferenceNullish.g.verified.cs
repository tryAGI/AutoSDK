//HintName: G.Models.ObjectReferenceNullish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the event was copied from another object.
    /// </summary>
    public sealed partial class ObjectReferenceNullish
    {
        /// <summary>
        /// Type of the object the event is originating from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjectReferenceNullishObjectType ObjectType { get; set; }

        /// <summary>
        /// ID of the object the event is originating from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// ID of the original event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Transaction ID of the original event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_xact_id")]
        public string? XactId { get; set; }

        /// <summary>
        /// Created timestamp of the original event. Used to help sort in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectReferenceNullish" /> class.
        /// </summary>
        /// <param name="objectType">
        /// Type of the object the event is originating from.
        /// </param>
        /// <param name="objectId">
        /// ID of the object the event is originating from.
        /// </param>
        /// <param name="id">
        /// ID of the original event.
        /// </param>
        /// <param name="xactId">
        /// Transaction ID of the original event.
        /// </param>
        /// <param name="created">
        /// Created timestamp of the original event. Used to help sort in the UI
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectReferenceNullish(
            global::G.ObjectReferenceNullishObjectType objectType,
            global::System.Guid objectId,
            string id,
            string? xactId,
            string? created)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.XactId = xactId;
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectReferenceNullish" /> class.
        /// </summary>
        public ObjectReferenceNullish()
        {
        }
    }
}