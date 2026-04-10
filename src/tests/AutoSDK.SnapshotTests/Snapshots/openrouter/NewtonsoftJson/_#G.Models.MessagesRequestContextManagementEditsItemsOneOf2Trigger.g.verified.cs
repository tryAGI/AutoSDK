//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf2Trigger.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItemsOneOf2Trigger
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TriggerTypeJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf2TriggerType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf2Trigger" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public MessagesRequestContextManagementEditsItemsOneOf2Trigger(
            double value,
            global::G.MessagesRequestContextManagementEditsItemsOneOf2TriggerType type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf2Trigger" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf2Trigger()
        {
        }
    }
}