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
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_prompt")]
        public global::G.PromptData? InlinePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> InlineFunction { get; set; }

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionTypeEnumJsonConverter))]
        public global::G.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// The name of the inline function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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