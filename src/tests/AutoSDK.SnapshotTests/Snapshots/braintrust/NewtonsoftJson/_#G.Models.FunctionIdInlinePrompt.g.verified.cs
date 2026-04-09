//HintName: G.Models.FunctionIdInlinePrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inline prompt definition
    /// </summary>
    public sealed partial class FunctionIdInlinePrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptData InlinePrompt { get; set; } = default!;

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionTypeEnumJsonConverter))]
        public global::G.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// The name of the inline prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlinePrompt" /> class.
        /// </summary>
        /// <param name="inlinePrompt"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        /// <param name="name">
        /// The name of the inline prompt
        /// </param>
        public FunctionIdInlinePrompt(
            global::G.PromptData inlinePrompt,
            global::G.FunctionTypeEnum? functionType,
            string? name)
        {
            this.InlinePrompt = inlinePrompt ?? throw new global::System.ArgumentNullException(nameof(inlinePrompt));
            this.FunctionType = functionType;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlinePrompt" /> class.
        /// </summary>
        public FunctionIdInlinePrompt()
        {
        }
    }
}