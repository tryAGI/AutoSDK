//HintName: G.IApi.GetChat.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve details of a specific chat
        /// </summary>
        /// <param name="chatId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> GetChatAsync(
            string chatId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}