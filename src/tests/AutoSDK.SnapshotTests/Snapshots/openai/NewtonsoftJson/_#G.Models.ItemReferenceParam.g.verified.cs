//HintName: G.Models.ItemReferenceParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An internal identifier for an item to reference.
    /// </summary>
    public sealed partial class ItemReferenceParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ItemReferenceParamType2? Type { get; set; }

        /// <summary>
        /// The ID of the item to reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceParam" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// The ID of the item to reference.
        /// </param>
        public ItemReferenceParam(
            string id,
            global::G.ItemReferenceParamType2? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceParam" /> class.
        /// </summary>
        public ItemReferenceParam()
        {
        }
    }
}