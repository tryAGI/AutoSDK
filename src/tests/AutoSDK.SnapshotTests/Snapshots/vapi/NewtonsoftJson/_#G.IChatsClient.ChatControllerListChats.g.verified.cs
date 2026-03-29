//HintName: G.IChatsClient.ChatControllerListChats.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// List Chats
        /// </summary>
        /// <param name="id"></param>
        /// <param name="assistantId"></param>
        /// <param name="assistantIdAny">
        /// Example: assistant-1,assistant-2,assistant-3
        /// </param>
        /// <param name="squadId"></param>
        /// <param name="sessionId"></param>
        /// <param name="previousChatId"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatPaginatedResponse> ChatControllerListChatsAsync(
            string? id = default,
            string? assistantId = default,
            string? assistantIdAny = default,
            string? squadId = default,
            string? sessionId = default,
            string? previousChatId = default,
            double? page = default,
            global::G.ChatControllerListChatsSortOrder? sortOrder = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}