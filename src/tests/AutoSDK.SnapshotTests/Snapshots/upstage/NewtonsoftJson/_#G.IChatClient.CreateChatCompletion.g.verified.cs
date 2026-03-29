//HintName: G.IChatClient.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create chat completion<br/>
        /// Creates a model response for the given chat conversation.<br/>
        /// Supports Solar Pro, Solar Mini, and Solar Mini JA models.<br/>
        /// Compatible with OpenAI chat completions API format.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> CreateChatCompletionAsync(

            global::G.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create chat completion<br/>
        /// Creates a model response for the given chat conversation.<br/>
        /// Supports Solar Pro, Solar Mini, and Solar Mini JA models.<br/>
        /// Compatible with OpenAI chat completions API format.
        /// </summary>
        /// <param name="model">
        /// The model to use for chat completion.<br/>
        /// Available models: solar-pro, solar-mini, solar-mini-ja<br/>
        /// Example: solar-pro
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 2. Higher values make output more random.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. Only tokens with top_p probability mass are considered.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate in the response.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// If specified, the system will make a best effort to sample deterministically.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalizes new tokens based on their existing frequency in the text so far.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="presencePenalty">
        /// Penalizes new tokens based on whether they appear in the text so far.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            int? n = default,
            int? seed = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools = default,
            global::G.OneOf<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>? toolChoice = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}