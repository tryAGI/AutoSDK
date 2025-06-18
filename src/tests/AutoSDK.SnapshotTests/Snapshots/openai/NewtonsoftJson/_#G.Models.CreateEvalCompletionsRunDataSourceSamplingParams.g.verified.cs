//HintName: G.Models.CreateEvalCompletionsRunDataSourceSamplingParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSourceSamplingParams
    {
        /// <summary>
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? ResponseFormat { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceSamplingParams" /> class.
        /// </summary>
        /// <param name="temperature">
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens in the generated output.
        /// </param>
        /// <param name="topP">
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        public CreateEvalCompletionsRunDataSourceSamplingParams(
            double? temperature,
            int? maxCompletionTokens,
            double? topP,
            int? seed,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? responseFormat,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools)
        {
            this.Temperature = temperature;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.TopP = topP;
            this.Seed = seed;
            this.ResponseFormat = responseFormat;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceSamplingParams" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceSamplingParams()
        {
        }
    }
}