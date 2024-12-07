//HintName: G.Models.CompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionRequest
    {
        /// <summary>
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Model Model { get; set; }

        /// <summary>
        /// The prompt that you want Claude to complete.<br/>
        /// For proper response generation you will need to format your prompt using alternating `\n\nHuman:` and `\n\nAssistant:` conversational turns. For example:<br/>
        /// ```<br/>
        /// "\n\nHuman: {userQuestion}\n\nAssistant:"<br/>
        /// ```<br/>
        /// See [prompt validation](https://docs.anthropic.com/en/api/prompt-validation) and our guide to [prompt design](https://docs.anthropic.com/en/docs/intro-to-prompting) for more details.<br/>
        /// Example: <br/>
        /// Human: Hello, world!<br/>
        /// Assistant:
        /// </summary>
        /// <example>
        /// Human: Hello, world!<br/>
        /// Assistant:
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate before stopping.<br/>
        /// Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.<br/>
        /// Example: 256
        /// </summary>
        /// <example>256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_to_sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokensToSample { get; set; }

        /// <summary>
        /// Sequences that will cause the model to stop generating.<br/>
        /// Our models stop on `"\n\nHuman:"`, and may include additional built-in stop sequences in the future. By providing the stop_sequences parameter, you may include additional strings that will cause the model to stop generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Amount of randomness injected into the response.<br/>
        /// Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0` for analytical / multiple choice, and closer to `1.0` for creative and generative tasks.<br/>
        /// Note that even with `temperature` of `0.0`, the results will not be fully deterministic.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Use nucleus sampling.<br/>
        /// In nucleus sampling, we compute the cumulative distribution over all the options for each subsequent token in decreasing probability order and cut it off once it reaches a particular probability specified by `top_p`. You should either alter `temperature` or `top_p`, but not both.<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Only sample from the top K options for each subsequent token.<br/>
        /// Used to remove "long tail" low probability responses. [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// An object describing metadata about the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// Whether to incrementally stream the response using server-sent events.<br/>
        /// See [streaming](https://docs.anthropic.com/en/api/streaming) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="prompt">
        /// The prompt that you want Claude to complete.<br/>
        /// For proper response generation you will need to format your prompt using alternating `\n\nHuman:` and `\n\nAssistant:` conversational turns. For example:<br/>
        /// ```<br/>
        /// "\n\nHuman: {userQuestion}\n\nAssistant:"<br/>
        /// ```<br/>
        /// See [prompt validation](https://docs.anthropic.com/en/api/prompt-validation) and our guide to [prompt design](https://docs.anthropic.com/en/docs/intro-to-prompting) for more details.<br/>
        /// Example: <br/>
        /// Human: Hello, world!<br/>
        /// Assistant:
        /// </param>
        /// <param name="maxTokensToSample">
        /// The maximum number of tokens to generate before stopping.<br/>
        /// Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.<br/>
        /// Example: 256
        /// </param>
        /// <param name="stopSequences">
        /// Sequences that will cause the model to stop generating.<br/>
        /// Our models stop on `"\n\nHuman:"`, and may include additional built-in stop sequences in the future. By providing the stop_sequences parameter, you may include additional strings that will cause the model to stop generating.
        /// </param>
        /// <param name="temperature">
        /// Amount of randomness injected into the response.<br/>
        /// Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0` for analytical / multiple choice, and closer to `1.0` for creative and generative tasks.<br/>
        /// Note that even with `temperature` of `0.0`, the results will not be fully deterministic.<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// Use nucleus sampling.<br/>
        /// In nucleus sampling, we compute the cumulative distribution over all the options for each subsequent token in decreasing probability order and cut it off once it reaches a particular probability specified by `top_p`. You should either alter `temperature` or `top_p`, but not both.<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="topK">
        /// Only sample from the top K options for each subsequent token.<br/>
        /// Used to remove "long tail" low probability responses. [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 5
        /// </param>
        /// <param name="metadata">
        /// An object describing metadata about the request.
        /// </param>
        /// <param name="stream">
        /// Whether to incrementally stream the response using server-sent events.<br/>
        /// See [streaming](https://docs.anthropic.com/en/api/streaming) for details.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CompletionRequest(
            global::G.Model model,
            string prompt,
            int maxTokensToSample,
            global::System.Collections.Generic.IList<string>? stopSequences,
            double? temperature,
            double? topP,
            int? topK,
            global::G.Metadata? metadata,
            bool? stream)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MaxTokensToSample = maxTokensToSample;
            this.StopSequences = stopSequences;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Metadata = metadata;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        public CompletionRequest()
        {
        }
    }
}