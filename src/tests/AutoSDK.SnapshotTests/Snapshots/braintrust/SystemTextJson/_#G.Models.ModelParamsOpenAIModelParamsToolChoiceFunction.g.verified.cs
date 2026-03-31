//HintName: G.Models.ModelParamsOpenAIModelParamsToolChoiceFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParamsOpenAIModelParamsToolChoiceFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter))]
        public global::G.ModelParamsOpenAIModelParamsToolChoiceFunctionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParamsToolChoiceFunction" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParamsOpenAIModelParamsToolChoiceFunction(
            global::G.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction function,
            global::G.ModelParamsOpenAIModelParamsToolChoiceFunctionType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParamsToolChoiceFunction" /> class.
        /// </summary>
        public ModelParamsOpenAIModelParamsToolChoiceFunction()
        {
        }
    }
}