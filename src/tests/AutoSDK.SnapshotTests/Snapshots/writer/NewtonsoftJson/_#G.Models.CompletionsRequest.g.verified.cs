//HintName: G.Models.CompletionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"model":"palmyra-x-003-instruct","prompt":"Write me an SEO article about...","max_tokens":150,"temperature":0.7,"top_p":0.9,"stop":["."],"best_of":1,"random_seed":42,"stream":false}
    /// </summary>
    public sealed partial class CompletionsRequest
    {
        /// <summary>
        /// The [ID of the model](https://dev.writer.com/home/models) to use for generating text. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The input text that the model will process to generate a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The maximum number of tokens that the model can generate in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// Controls the randomness of the model's outputs. Higher values lead to more random outputs, while lower values make the model more deterministic.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Used to control the nucleus sampling, where only the most probable tokens with a cumulative probability of top_p are considered for sampling, providing a way to fine-tune the randomness of predictions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Specifies stopping conditions for the model's output generation. This can be an array of strings or a single string that the model will look for as a signal to stop generating further tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? Stop { get; set; }

        /// <summary>
        /// Specifies the number of completions to generate and return the best one. Useful for generating multiple outputs and choosing the best based on some criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("best_of")]
        public int? BestOf { get; set; }

        /// <summary>
        /// A seed used to initialize the random number generator for the model, ensuring reproducibility of the output when the same inputs are provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// Determines whether the model's output should be streamed. If true, the output is generated and sent incrementally, which can be useful for real-time applications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The [ID of the model](https://dev.writer.com/home/models) to use for generating text. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.
        /// </param>
        /// <param name="prompt">
        /// The input text that the model will process to generate a response.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that the model can generate in the response.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the model's outputs. Higher values lead to more random outputs, while lower values make the model more deterministic.
        /// </param>
        /// <param name="topP">
        /// Used to control the nucleus sampling, where only the most probable tokens with a cumulative probability of top_p are considered for sampling, providing a way to fine-tune the randomness of predictions.
        /// </param>
        /// <param name="stop">
        /// Specifies stopping conditions for the model's output generation. This can be an array of strings or a single string that the model will look for as a signal to stop generating further tokens.
        /// </param>
        /// <param name="bestOf">
        /// Specifies the number of completions to generate and return the best one. Useful for generating multiple outputs and choosing the best based on some criteria.
        /// </param>
        /// <param name="randomSeed">
        /// A seed used to initialize the random number generator for the model, ensuring reproducibility of the output when the same inputs are provided.
        /// </param>
        /// <param name="stream">
        /// Determines whether the model's output should be streamed. If true, the output is generated and sent incrementally, which can be useful for real-time applications.
        /// </param>
        public CompletionsRequest(
            string model,
            string prompt,
            long? maxTokens,
            double? temperature,
            double? topP,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop,
            int? bestOf,
            int? randomSeed,
            bool? stream)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Stop = stop;
            this.BestOf = bestOf;
            this.RandomSeed = randomSeed;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsRequest" /> class.
        /// </summary>
        public CompletionsRequest()
        {
        }
    }
}