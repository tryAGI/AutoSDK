//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf1Keep0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItemsOneOf1Keep0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0TypeJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf1Keep0" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep0(
            double value,
            global::G.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf1Keep0" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep0()
        {
        }
    }
}