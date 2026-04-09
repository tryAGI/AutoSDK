//HintName: G.Models.BaseMessagesResultContentItemsOneOf5Caller1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf5Caller1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5Caller1" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf5Caller1(
            string toolId,
            global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf1Type type)
        {
            this.Type = type;
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5Caller1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Caller1()
        {
        }
    }
}