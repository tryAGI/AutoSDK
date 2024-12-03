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
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("echo")]
        public bool? Echo { get; set; }

        /// <summary>
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Adjusts the likelihood of specific tokens appearing in the generated output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, float>? LogitBias { get; set; }

        /// <summary>
        /// Determines the number of most likely tokens to return at each token position log probabilities to return.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public int? Logprobs { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A number between 0 and 1 that can be used as an alternative to top-p and top-k.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_p")]
        public float? MinP { get; set; }

        /// <summary>
        /// The name of the model to query.<br/>
        /// Default Value: mistralai/Mixtral-8x7B-Instruct-v0.1<br/>
        /// Example: mistralai/Mixtral-8x7B-Instruct-v0.1
        /// </summary>
        /// <default>"mistralai/Mixtral-8x7B-Instruct-v0.1"</default>
        /// <example>mistralai/Mixtral-8x7B-Instruct-v0.1</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The number of completions to generate for each prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// A string providing context for the model to complete.<br/>
        /// Default Value: &lt;s&gt;[INST] What is the capital of France? [/INST]<br/>
        /// Example: &lt;s&gt;[INST] What is the capital of France? [/INST]
        /// </summary>
        /// <default>"&lt;s&gt;[INST] What is the capital of France? [/INST]"</default>
        /// <example>&lt;s&gt;[INST] What is the capital of France? [/INST]</example>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetition_penalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </summary>
        /// <example>safety_model_name</example>
        [global::Newtonsoft.Json.JsonProperty("safety_model")]
        public string? SafetyModel { get; set; }

        /// <summary>
        /// Seed value for reproducibility.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with `data: [DONE]`. If false, return a single JSON object containing the results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        /// <param name="echo">
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </param>
        /// <param name="logitBias">
        /// Adjusts the likelihood of specific tokens appearing in the generated output.
        /// </param>
        /// <param name="logprobs">
        /// Determines the number of most likely tokens to return at each token position log probabilities to return.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="minP">
        /// A number between 0 and 1 that can be used as an alternative to top-p and top-k.
        /// </param>
        /// <param name="model">
        /// The name of the model to query.<br/>
        /// Default Value: mistralai/Mixtral-8x7B-Instruct-v0.1<br/>
        /// Example: mistralai/Mixtral-8x7B-Instruct-v0.1
        /// </param>
        /// <param name="n">
        /// The number of completions to generate for each prompt.
        /// </param>
        /// <param name="presencePenalty">
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </param>
        /// <param name="prompt">
        /// A string providing context for the model to complete.<br/>
        /// Default Value: &lt;s&gt;[INST] What is the capital of France? [/INST]<br/>
        /// Example: &lt;s&gt;[INST] What is the capital of France? [/INST]
        /// </param>
        /// <param name="repetitionPenalty">
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </param>
        /// <param name="safetyModel">
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </param>
        /// <param name="seed">
        /// Seed value for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="stop">
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </param>
        /// <param name="stream">
        /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with `data: [DONE]`. If false, return a single JSON object containing the results.
        /// </param>
        /// <param name="temperature">
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </param>
        /// <param name="topK">
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </param>
        /// <param name="topP">
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </param>
        public CompletionRequest(
            string model,
            string prompt,
            bool? echo,
            float? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias,
            int? logprobs,
            int? maxTokens,
            float? minP,
            int? n,
            float? presencePenalty,
            float? repetitionPenalty,
            string? safetyModel,
            int? seed,
            global::System.Collections.Generic.IList<string>? stop,
            bool? stream,
            float? temperature,
            int? topK,
            float? topP)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Echo = echo;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.MaxTokens = maxTokens;
            this.MinP = minP;
            this.N = n;
            this.PresencePenalty = presencePenalty;
            this.RepetitionPenalty = repetitionPenalty;
            this.SafetyModel = safetyModel;
            this.Seed = seed;
            this.Stop = stop;
            this.Stream = stream;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        public CompletionRequest()
        {
        }
    }
}