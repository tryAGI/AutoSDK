//HintName: G.ISubpackageTasksSubpackageTasksTransfersClient.GetStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTasksSubpackageTasksTransfersClient
    {
        /// <summary>
        /// Get Status
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetStatusAsync(
            string integrationId,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}