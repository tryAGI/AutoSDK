//HintName: G.IApi.ListChat.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all chats
        /// </summary>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatResponse>> ListChatAsync(
            global::G.ListChatSortOrder? sortOrder = default,
            int? limit = default,
            string? paginationKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}