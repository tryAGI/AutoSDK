//HintName: G.ITriggersClient.GetCliRealtimeCredentials.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Get credentials for CLI realtime events<br/>
        /// Get the Pusher key and project nanoId for the CLI realtime trigger channel. The CLI subscribes to private-cli-{project_id}.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCliRealtimeCredentialsResponse> GetCliRealtimeCredentialsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}