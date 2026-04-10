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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter))]
        public global::G.ModelParamsOpenAIModelParamsToolChoiceFunctionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParamsToolChoiceFunction" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
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