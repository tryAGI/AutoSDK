//HintName: G.Models.BaseMessagesResultContentItemsOneOf10Content1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf10Content1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_references", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems> ToolReferences { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10Content1" /> class.
        /// </summary>
        /// <param name="toolReferences"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf10Content1(
            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems> toolReferences,
            global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1Type type)
        {
            this.ToolReferences = toolReferences ?? throw new global::System.ArgumentNullException(nameof(toolReferences));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10Content1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf10Content1()
        {
        }
    }
}