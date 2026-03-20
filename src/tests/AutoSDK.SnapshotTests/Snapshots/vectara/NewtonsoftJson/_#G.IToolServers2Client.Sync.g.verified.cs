//HintName: G.IToolServers2Client.Sync.g.cs
#nullable enable

namespace G
{
    public partial interface IToolServers2Client
    {
        /// <summary>
        /// Synchronize tool server<br/>
        /// Trigger a synchronization of the tool server to ensure it is up-to-date with the latest tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SyncAsync(
            string toolServerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}