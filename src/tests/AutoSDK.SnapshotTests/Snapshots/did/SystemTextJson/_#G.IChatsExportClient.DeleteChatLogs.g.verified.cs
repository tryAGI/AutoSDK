//HintName: G.IChatsExportClient.DeleteChatLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsExportClient
    {
        /// <summary>
        /// Delete chat logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteChatLogsResponse> DeleteChatLogsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}