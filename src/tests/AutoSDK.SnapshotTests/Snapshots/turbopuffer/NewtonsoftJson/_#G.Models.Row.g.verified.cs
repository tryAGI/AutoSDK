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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Id Id { get; set; } = default!;

        /// <summary>
        /// A vector embedding associated with a document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector")]
        public global::G.Vector2? Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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