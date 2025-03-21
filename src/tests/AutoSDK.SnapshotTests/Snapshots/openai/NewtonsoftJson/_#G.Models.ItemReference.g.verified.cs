//HintName: G.Models.ItemReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An internal identifier for an item to reference.
    /// </summary>
    public sealed partial class ItemReference
    {
        /// <summary>
        /// The ID of the item to reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of item to reference. Always `item_reference`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ItemReferenceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the item to reference.
        /// </param>
        /// <param name="type">
        /// The type of item to reference. Always `item_reference`.
        /// </param>
        public ItemReference(
            string id,
            global::G.ItemReferenceType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReference" /> class.
        /// </summary>
        public ItemReference()
        {
        }
    }
}