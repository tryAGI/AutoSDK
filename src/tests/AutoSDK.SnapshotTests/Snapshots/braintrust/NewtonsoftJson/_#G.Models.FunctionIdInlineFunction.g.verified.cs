//HintName: G.Models.FunctionIdInlineFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inline function definition
    /// </summary>
    public sealed partial class FunctionIdInlineFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_prompt")]
        public global::G.PromptData? InlinePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> InlineFunction { get; set; } = default!;

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        public global::G.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// The name of the inline function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlineFunction" /> class.
        /// </summary>
        /// <param name="inlineFunction"></param>
        /// <param name="inlinePrompt"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        /// <param name="name">
        /// The name of the inline function
        /// </param>
        public FunctionIdInlineFunction(
            global::System.Collections.Generic.Dictionary<string, object?> inlineFunction,
            global::G.PromptData? inlinePrompt,
            global::G.FunctionTypeEnum? functionType,
            string? name)
        {
            this.InlinePrompt = inlinePrompt;
            this.InlineFunction = inlineFunction ?? throw new global::System.ArgumentNullException(nameof(inlineFunction));
            this.FunctionType = functionType;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlineFunction" /> class.
        /// </summary>
        public FunctionIdInlineFunction()
        {
        }
    }
}