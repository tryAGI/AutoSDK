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
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObjectReferenceNullishObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// ID of the object the event is originating from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ObjectId { get; set; } = default!;

        /// <summary>
        /// ID of the original event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Transaction ID of the original event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_xact_id")]
        public string? XactId { get; set; }

        /// <summary>
        /// Created timestamp of the original event. Used to help sort in the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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