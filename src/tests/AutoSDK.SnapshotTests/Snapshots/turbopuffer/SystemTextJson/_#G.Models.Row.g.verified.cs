//HintName: G.Models.Row.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single document, in a row-based format.
    /// </summary>
    public sealed partial class Row
    {
        /// <summary>
        /// An identifier for a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Id Id { get; set; }

        /// <summary>
        /// A vector embedding associated with a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Vector2JsonConverter))]
        public global::G.Vector2? Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        /// <param name="id">
        /// An identifier for a document.
        /// </param>
        /// <param name="vector">
        /// A vector embedding associated with a document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Row(
            global::G.Id id,
            global::G.Vector2? vector)
        {
            this.Id = id;
            this.Vector = vector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        public Row()
        {
        }
    }
}