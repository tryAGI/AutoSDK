//HintName: G.Models.PromptData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptBlockDataNullishJsonConverter))]
        public global::G.PromptBlockDataNullish? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.PromptOptionsNullish? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parser")]
        public global::G.PromptParserNullish? Parser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_functions")]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.PromptDataToolFunctionVariant2Function, global::G.PromptDataToolFunctionVariant2Global>?>>? ToolFunctions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptDataTemplateFormatJsonConverter))]
        public global::G.PromptDataTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        public object? Mcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public global::G.PromptDataOrigin? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptData" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="options"></param>
        /// <param name="parser"></param>
        /// <param name="toolFunctions"></param>
        /// <param name="templateFormat"></param>
        /// <param name="mcp"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptData(
            global::G.PromptBlockDataNullish? prompt,
            global::G.PromptOptionsNullish? options,
            global::G.PromptParserNullish? parser,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.PromptDataToolFunctionVariant2Function, global::G.PromptDataToolFunctionVariant2Global>?>>? toolFunctions,
            global::G.PromptDataTemplateFormat? templateFormat,
            object? mcp,
            global::G.PromptDataOrigin? origin)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.Parser = parser;
            this.ToolFunctions = toolFunctions;
            this.TemplateFormat = templateFormat;
            this.Mcp = mcp;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptData" /> class.
        /// </summary>
        public PromptData()
        {
        }
    }
}