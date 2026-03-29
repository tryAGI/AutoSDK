//HintName: G.Models.ResponseItemReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An internal identifier for an item to reference.
    /// </summary>
    public sealed partial class ResponseItemReference
    {
        /// <summary>
        /// The type of item to reference. Always `item_reference`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseItemReferenceTypeJsonConverter))]
        public global::G.ResponseItemReferenceType Type { get; set; }

        /// <summary>
        /// The ID of the item to reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the item to reference.
        /// </param>
        /// <param name="type">
        /// The type of item to reference. Always `item_reference`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemReference(
            string id,
            global::G.ResponseItemReferenceType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemReference" /> class.
        /// </summary>
        public ResponseItemReference()
        {
        }
    }
}