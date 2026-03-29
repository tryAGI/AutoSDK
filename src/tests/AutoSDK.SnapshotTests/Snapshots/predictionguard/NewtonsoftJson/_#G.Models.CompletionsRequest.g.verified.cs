//HintName: G.Models.CompletionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionsRequest
    {
        /// <summary>
        /// The chat model to use for generating completions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt Prompt { get; set; } = default!;

        /// <summary>
        /// A value between -2.0 and 2.0, with positive values increasingly penalizing new tokens based on their frequency so far in order to decrease further occurrences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Modifies the likelihood of specified tokens appearing in a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logit_bias")]
        public global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias? LogitBias { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A value between -2.0 and 2.0, with positive values causing a flat reduction of new tokens based on their existing presence so far in order to decrease further occurrences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaStop? Stop { get; set; }

        /// <summary>
        /// Whether to stream back the model response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Extra parameters used when streaming the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_options")]
        public global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The diversity of the generated text based on top-k sampling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Options to affect the output of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaOutput? Output { get; set; }

        /// <summary>
        /// Options to affect the input of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaInput? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The chat model to use for generating completions.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="frequencyPenalty">
        /// A value between -2.0 and 2.0, with positive values increasingly penalizing new tokens based on their frequency so far in order to decrease further occurrences.
        /// </param>
        /// <param name="logitBias">
        /// Modifies the likelihood of specified tokens appearing in a response.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens in the generated completion.
        /// </param>
        /// <param name="presencePenalty">
        /// A value between -2.0 and 2.0, with positive values causing a flat reduction of new tokens based on their existing presence so far in order to decrease further occurrences.
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Whether to stream back the model response.
        /// </param>
        /// <param name="streamOptions">
        /// Extra parameters used when streaming the response.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="topP">
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </param>
        /// <param name="topK">
        /// The diversity of the generated text based on top-k sampling.
        /// </param>
        /// <param name="output">
        /// Options to affect the output of the response.
        /// </param>
        /// <param name="input">
        /// Options to affect the input of the request.
        /// </param>
        public CompletionsRequest(
            string model,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            double? frequencyPenalty,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias? logitBias,
            int? maxTokens,
            double? presencePenalty,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaStop? stop,
            bool? stream,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions? streamOptions,
            double? temperature,
            double? topP,
            int? topK,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaOutput? output,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaInput? input)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.MaxTokens = maxTokens;
            this.PresencePenalty = presencePenalty;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Output = output;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsRequest" /> class.
        /// </summary>
        public CompletionsRequest()
        {
        }
    }
}