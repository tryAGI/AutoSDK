//HintName: G.IServerlessClient.ServerlessGetAppQueueInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Queue Size<br/>
        /// Retrieves the current queue size for a specific application.
        /// </summary>
        /// <param name="owner">
        /// Username of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="name">
        /// Application name<br/>
        /// Example: my-app
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServerlessGetAppQueueInfoResponse> ServerlessGetAppQueueInfoAsync(
            string owner,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}