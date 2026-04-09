//HintName: G.Models.BaseMessagesResultContentItems5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItems5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caller", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf5Caller Caller { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf5Content Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems5" /> class.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="toolUseId"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItems5(
            global::G.BaseMessagesResultContentItemsOneOf5Caller caller,
            string toolUseId,
            global::G.BaseMessagesResultContentItemsOneOf5Content content,
            global::G.BaseMessagesResultContentItemsOneOf5Type type)
        {
            this.Type = type;
            this.Caller = caller;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems5" /> class.
        /// </summary>
        public BaseMessagesResultContentItems5()
        {
        }
    }
}