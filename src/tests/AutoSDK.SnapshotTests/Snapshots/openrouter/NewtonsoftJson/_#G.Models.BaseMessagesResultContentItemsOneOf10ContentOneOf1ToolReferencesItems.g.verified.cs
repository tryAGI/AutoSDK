//HintName: G.Models.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems(
            string toolName,
            global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType type)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems()
        {
        }
    }
}