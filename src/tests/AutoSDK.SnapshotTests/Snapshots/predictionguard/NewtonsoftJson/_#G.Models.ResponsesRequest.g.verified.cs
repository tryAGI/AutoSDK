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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInput Input { get; set; } = default!;

        /// <summary>
        /// A system (or developer) message inserted into the model's context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// The maximum amount of tool calls the model is able to do.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Constrains effort on reasoning for reasoning models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning? Reasoning { get; set; }

        /// <summary>
        /// Whether to stream back the model response. Not currently supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Extra parameters used when streaming the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_options")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// The content of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems>? Tools { get; set; }

        /// <summary>
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Safeguards to run on the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safeguards")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards? Safeguards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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