//HintName: G.Models.ResponsesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesRequest
    {
        /// <summary>
        /// The AI model to use for generating responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInput Input { get; set; }

        /// <summary>
        /// A system (or developer) message inserted into the model's context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// The maximum amount of tool calls the model is able to do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Constrains effort on reasoning for reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning? Reasoning { get; set; }

        /// <summary>
        /// Whether to stream back the model response. Not currently supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Extra parameters used when streaming the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceJsonConverter))]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// The content of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems>? Tools { get; set; }

        /// <summary>
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Safeguards to run on the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safeguards")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards? Safeguards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The AI model to use for generating responses.
        /// </param>
        /// <param name="input"></param>
        /// <param name="instructions">
        /// A system (or developer) message inserted into the model's context.
        /// </param>
        /// <param name="maxOutputTokens">
        /// The maximum number of tokens in the generated output.
        /// </param>
        /// <param name="maxToolCalls">
        /// The maximum amount of tool calls the model is able to do.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use.
        /// </param>
        /// <param name="reasoning">
        /// Constrains effort on reasoning for reasoning models.
        /// </param>
        /// <param name="stream">
        /// Whether to stream back the model response. Not currently supported.
        /// </param>
        /// <param name="streamOptions">
        /// Extra parameters used when streaming the response.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="tools">
        /// The content of the tool call.
        /// </param>
        /// <param name="topP">
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </param>
        /// <param name="safeguards">
        /// Safeguards to run on the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequest(
            string model,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInput input,
            string? instructions,
            int? maxOutputTokens,
            int? maxToolCalls,
            bool? parallelToolCalls,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning? reasoning,
            bool? stream,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions? streamOptions,
            double? temperature,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems>? tools,
            double? topP,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards? safeguards)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.ParallelToolCalls = parallelToolCalls;
            this.Reasoning = reasoning;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopP = topP;
            this.Safeguards = safeguards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        public ResponsesRequest()
        {
        }
    }
}