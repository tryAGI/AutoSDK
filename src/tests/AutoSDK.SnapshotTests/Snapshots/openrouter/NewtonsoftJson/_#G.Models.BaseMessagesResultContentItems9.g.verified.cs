//HintName: G.Models.BaseMessagesResultContentItems9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItems9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf9Content Content { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems9" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItems9(
            global::G.BaseMessagesResultContentItemsOneOf9Content content,
            string toolUseId,
            global::G.BaseMessagesResultContentItemsOneOf9Type type)
        {
            this.Type = type;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems9" /> class.
        /// </summary>
        public BaseMessagesResultContentItems9()
        {
        }
    }
}