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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems> ToolReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10Content1" /> class.
        /// </summary>
        /// <param name="toolReferences"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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