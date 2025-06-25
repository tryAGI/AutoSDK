//HintName: G.IApi.OpenaiChatCompletionsV1OpenaiChatCompletionsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Chat Completions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiChatCompletionsV1OpenaiChatCompletionsPostAsync(
            global::G.OpenAIChatCompletionsIn request,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Chat Completions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiChatCompletionsV1OpenaiChatCompletionsPostAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>> messages,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            double? minP = default,
            int? topK = default,
            int? maxTokens = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            int? n = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.IList<global::G.ChatTools>? tools = default,
            string? toolChoice = default,
            global::G.ResponseFormat? responseFormat = default,
            double? repetitionPenalty = default,
            string? user = default,
            int? seed = default,
            bool? logprobs = default,
            global::G.StreamOptions? streamOptions = default,
            global::G.OpenAIChatCompletionsInReasoningEffort? reasoningEffort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}