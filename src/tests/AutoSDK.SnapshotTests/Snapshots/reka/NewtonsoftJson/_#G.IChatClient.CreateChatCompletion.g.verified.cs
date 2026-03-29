//HintName: G.IChatClient.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion for the provided messages and model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(

            global::G.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion for the provided messages and model.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness. 0.0 is deterministic.<br/>
        /// Default Value: 0.4
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling threshold. Only tokens with cumulative probability up to top_p are considered.<br/>
        /// Default Value: 0.95
        /// </param>
        /// <param name="topK">
        /// Consider only top-k most probable tokens at each step.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalizes repeated tokens. Positive values reduce repetition.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="presencePenalty">
        /// Penalizes tokens that have appeared in the output. Positive values encourage new topics.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool is called by the model.
        /// </param>
        /// <param name="research">
        /// Configuration for the Reka Research model (reka-flash-research). Controls web search and parallel thinking.
        /// </param>
        /// <param name="responseFormat">
        /// Structured output configuration. Forces the model to return valid JSON matching a schema.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::G.ChatMessageInput> messages,
            string model,
            double? temperature = default,
            int? maxTokens = default,
            double? topP = default,
            int? topK = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            bool? stream = default,
            int? seed = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::G.CreateChatCompletionRequestToolChoice? toolChoice = default,
            global::G.ResearchConfig? research = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}