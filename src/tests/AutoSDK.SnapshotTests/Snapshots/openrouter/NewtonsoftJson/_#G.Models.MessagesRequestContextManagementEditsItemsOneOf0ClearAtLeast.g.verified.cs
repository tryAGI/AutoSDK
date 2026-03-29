//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast(
            double value,
            global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast()
        {
        }
    }
}