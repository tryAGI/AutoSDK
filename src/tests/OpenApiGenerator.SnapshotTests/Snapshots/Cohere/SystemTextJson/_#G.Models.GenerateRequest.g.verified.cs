//HintName: G.Models.GenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRequest
    {
        /// <summary>
        /// The input text that serves as the starting point for generating the response.<br/>
        /// Note: The prompt will be pre-processed and modified before reaching the model.<br/>
        /// Example: Please explain to me how LLMs work
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The identifier of the model to generate with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental).<br/>
        /// Smaller, "light" models are faster, while larger models will perform better. [Custom models](/docs/training-custom-models) can also be supplied with their full ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The maximum number of generations that will be returned. Defaults to `1`, min value of `1`, max value of `5`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_generations")]
        public int NumGenerations { get; set; }

        /// <summary>
        /// When `true`, the response will be a JSON stream of events. Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.<br/>
        /// The final event will contain the complete response, and will contain an `is_finished` field set to `true`. The event will also contain a `finish_reason`, which can be one of the following:<br/>
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; }

        /// <summary>
        /// The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.<br/>
        /// This parameter is off by default, and if it's not specified, the model will continue generating until it emits an EOS completion token. See [BPE Tokens](/bpe-tokens-wiki) for more details.<br/>
        /// Can only be set to `0` if `return_likelihoods` is set to `ALL` to get the likelihood of the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int MaxTokens { get; set; }

        /// <summary>
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.GenerateRequestTruncateJsonConverter))]
        public global::G.GenerateRequestTruncate? Truncate { get; set; } = global::G.GenerateRequestTruncate.END;

        /// <summary>
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations. See [Temperature](/temperature-wiki) for more details.<br/>
        /// Defaults to `0.75`, min value of `0.0`, max value of `5.0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double Temperature { get; set; }

        /// <summary>
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int Seed { get; set; }

        /// <summary>
        /// Identifier of a custom preset. A preset is a combination of parameters, such as prompt, temperature etc. You can create presets in the [playground](https://dashboard.cohere.com/playground/generate).<br/>
        /// When a preset is specified, the `prompt` parameter becomes optional, and any included parameters will override the preset's parameters.<br/>
        /// Example: my-preset-a58sbd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        public string? Preset { get; set; }

        /// <summary>
        /// The generated text will be cut at the beginning of the earliest occurrence of an end sequence. The sequence will be excluded from the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sequences")]
        public global::System.Collections.Generic.IList<string>? EndSequences { get; set; }

        /// <summary>
        /// The generated text will be cut at the end of the earliest occurrence of a stop sequence. The sequence will be included the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        public int K { get; set; }

        /// <summary>
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        public double P { get; set; }

        /// <summary>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.<br/>
        /// Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double FrequencyPenalty { get; set; }

        /// <summary>
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Can be used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.<br/>
        /// Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double PresencePenalty { get; set; }

        /// <summary>
        /// One of `GENERATION|ALL|NONE` to specify how and if the token likelihoods are returned with the response. Defaults to `NONE`.<br/>
        /// If `GENERATION` is selected, the token likelihoods will only be provided for generated text.<br/>
        /// If `ALL` is selected, the token likelihoods will be provided both for the prompt and the generated text.<br/>
        /// Default Value: NONE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_likelihoods")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter))]
        public global::G.GenerateRequestReturnLikelihoods? ReturnLikelihoods { get; set; } = global::G.GenerateRequestReturnLikelihoods.NONE;

        /// <summary>
        /// When enabled, the user's prompt will be sent to the model without any pre-processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_prompting")]
        public bool RawPrompting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}