//HintName: G.Models.OpenAIChatCompletionsIn.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatCompletionsIn
    {
        /// <summary>
        /// model name<br/>
        /// Example: meta-llama/Llama-2-70b-chat-hf
        /// </summary>
        /// <example>meta-llama/Llama-2-70b-chat-hf</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// conversation messages: (user,assistant,tool)*,user including one system message anywhere
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>> Messages { get; set; } = default!;

        /// <summary>
        /// whether to stream the output via SSE or return the full response<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Float that represents the minimum probability for a token to be considered, relative to the probability of the most likely token. Must be in [0, 1]. Set to 0 to disable this.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_p")]
        public double? MinP { get; set; }

        /// <summary>
        /// Sample from the best k (number of) tokens. 0 means off<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the chat completion.<br/>
        /// The total length of input tokens and generated tokens is limited by the model's context length. If explicitly set to None it will be the model's max context length minus input length or 16384, whichever is smaller.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// up to 16 sequences where the API will stop generating further tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// number of sequences to return<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatTools>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) function is called by the model. none means the model will not call a function and instead generates a message. auto means the model can pick between generating a message or calling a function. specifying a particular function choice is not supported currently.none is the default when no functions are present. auto is the default if functions are present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Alternative penalty for repetition, but multiplicative instead of additive (&gt; 1 penalize, &lt; 1 encourage)<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Seed for random number generator. If not provided, a random seed is used. Determinism is not guaranteed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Whether to return log probabilities of the output tokens or not.If true, returns the log probabilities of each output token returned in the `content` of `message`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_options")]
        public global::G.StreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Constrains effort on reasoning for reasoning models. Currently supported values are none, low, medium, and high. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Setting to none disables reasoning entirely if the model supports.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        public global::G.OpenAIChatCompletionsInReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletionsIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name<br/>
        /// Example: meta-llama/Llama-2-70b-chat-hf
        /// </param>
        /// <param name="messages">
        /// conversation messages: (user,assistant,tool)*,user including one system message anywhere
        /// </param>
        /// <param name="stream">
        /// whether to stream the output via SSE or return the full response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="minP">
        /// Float that represents the minimum probability for a token to be considered, relative to the probability of the most likely token. Must be in [0, 1]. Set to 0 to disable this.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="topK">
        /// Sample from the best k (number of) tokens. 0 means off<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the chat completion.<br/>
        /// The total length of input tokens and generated tokens is limited by the model's context length. If explicitly set to None it will be the model's max context length minus input length or 16384, whichever is smaller.
        /// </param>
        /// <param name="stop">
        /// up to 16 sequences where the API will stop generating further tokens
        /// </param>
        /// <param name="n">
        /// number of sequences to return<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="presencePenalty">
        /// Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="frequencyPenalty">
        /// Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model. none means the model will not call a function and instead generates a message. auto means the model can pick between generating a message or calling a function. specifying a particular function choice is not supported currently.none is the default when no functions are present. auto is the default if functions are present.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="repetitionPenalty">
        /// Alternative penalty for repetition, but multiplicative instead of additive (&gt; 1 penalize, &lt; 1 encourage)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.
        /// </param>
        /// <param name="seed">
        /// Seed for random number generator. If not provided, a random seed is used. Determinism is not guaranteed.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not.If true, returns the log probabilities of each output token returned in the `content` of `message`.
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="reasoningEffort">
        /// Constrains effort on reasoning for reasoning models. Currently supported values are none, low, medium, and high. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Setting to none disables reasoning entirely if the model supports.
        /// </param>
        public OpenAIChatCompletionsIn(
            string model,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>> messages,
            bool? stream,
            double? temperature,
            double? topP,
            double? minP,
            int? topK,
            int? maxTokens,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
            int? n,
            double? presencePenalty,
            double? frequencyPenalty,
            global::System.Collections.Generic.IList<global::G.ChatTools>? tools,
            string? toolChoice,
            global::G.ResponseFormat? responseFormat,
            double? repetitionPenalty,
            string? user,
            int? seed,
            bool? logprobs,
            global::G.StreamOptions? streamOptions,
            global::G.OpenAIChatCompletionsInReasoningEffort? reasoningEffort)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Stream = stream;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MinP = minP;
            this.TopK = topK;
            this.MaxTokens = maxTokens;
            this.Stop = stop;
            this.N = n;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ResponseFormat = responseFormat;
            this.RepetitionPenalty = repetitionPenalty;
            this.User = user;
            this.Seed = seed;
            this.Logprobs = logprobs;
            this.StreamOptions = streamOptions;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletionsIn" /> class.
        /// </summary>
        public OpenAIChatCompletionsIn()
        {
        }
    }
}