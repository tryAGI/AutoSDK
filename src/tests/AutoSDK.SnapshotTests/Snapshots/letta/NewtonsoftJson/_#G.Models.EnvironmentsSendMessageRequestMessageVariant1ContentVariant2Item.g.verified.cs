//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item(
            string text,
            global::G.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item()
        {
        }
    }
}