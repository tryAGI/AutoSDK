//HintName: G.IChatsClient.CreateChat.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Start a chat<br/>
        /// Create a chat while specifying the default retrieval parameters used by the prompt.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatFullResponse> CreateChatAsync(
            global::G.ChatRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start a chat<br/>
        /// Create a chat while specifying the default retrieval parameters used by the prompt.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="query">
        /// The chat message or question.<br/>
        /// Example: How can I use the Vectara platform?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="chat">
        /// Parameters to control chat behavior.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatFullResponse> CreateChatAsync(
            string query,
            global::G.SearchCorporaParameters search,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.GenerationParameters? generation = default,
            global::G.ChatParameters? chat = default,
            bool? streamResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}