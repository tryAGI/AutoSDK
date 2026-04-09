//HintName: G.IChatsExportClient.CreateChatLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsExportClient
    {
        /// <summary>
        /// Create chat logs<br/>
        /// Create a chat log export for `agent_id` containing all of the Agent's chats.<br/>
        /// Use the `export_id` in the GET chat logs endpoint to get the result of the create chat logs request (zipped JSON files).<br/>
        /// (The chat log export will be deleted from the database after 7 days from the export creation date)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatLogsResponse> CreateChatLogsAsync(

            global::G.AllOf<global::G.CreateChatLogsRequestVariant1, global::G.CreateChatLogsRequestVariant2> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create chat logs<br/>
        /// Create a chat log export for `agent_id` containing all of the Agent's chats.<br/>
        /// Use the `export_id` in the GET chat logs endpoint to get the result of the create chat logs request (zipped JSON files).<br/>
        /// (The chat log export will be deleted from the database after 7 days from the export creation date)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatLogsResponse> CreateChatLogsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}