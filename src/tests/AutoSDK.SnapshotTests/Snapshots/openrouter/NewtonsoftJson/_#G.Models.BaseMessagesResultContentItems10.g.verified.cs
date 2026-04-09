//HintName: G.Models.BaseMessagesResultContentItems10.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItems10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf10Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf10Content Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems10" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItems10(
            global::G.BaseMessagesResultContentItemsOneOf10Content content,
            string toolUseId,
            global::G.BaseMessagesResultContentItemsOneOf10Type type)
        {
            this.Type = type;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems10" /> class.
        /// </summary>
        public BaseMessagesResultContentItems10()
        {
        }
    }
}