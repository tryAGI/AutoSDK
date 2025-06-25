//HintName: G.Models.CreateEvalResponsesRunDataSourceSamplingParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSourceSamplingParams
    {
        /// <summary>
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// An array of tools the model may call while generating a response. You<br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// The two categories of tools you can provide the model are:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](/docs/guides/tools-web-search)<br/>
        ///   or [file search](/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](/docs/guides/tools).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code. Learn more about<br/>
        ///   [function calling](/docs/guides/function-calling).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Structured Outputs](/docs/guides/structured-outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::G.CreateEvalResponsesRunDataSourceSamplingParamsText? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceSamplingParams" /> class.
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
        /// <param name="tools">
        /// An array of tools the model may call while generating a response. You<br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// The two categories of tools you can provide the model are:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](/docs/guides/tools-web-search)<br/>
        ///   or [file search](/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](/docs/guides/tools).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code. Learn more about<br/>
        ///   [function calling](/docs/guides/function-calling).
        /// </param>
        /// <param name="text">
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Structured Outputs](/docs/guides/structured-outputs)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalResponsesRunDataSourceSamplingParams(
            double? temperature,
            int? maxCompletionTokens,
            double? topP,
            int? seed,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.CreateEvalResponsesRunDataSourceSamplingParamsText? text)
        {
            this.Temperature = temperature;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.TopP = topP;
            this.Seed = seed;
            this.Tools = tools;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceSamplingParams" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSourceSamplingParams()
        {
        }
    }
}