//HintName: G.IEmbedJobsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbedJobsClient
    {
        /// <summary>
        /// List Embed Jobs<br/>
        /// The list embed job endpoint allows users to view all embed jobs history for that specific user.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListEmbedJobResponse> ListAsync(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Embed Jobs<br/>
        /// The list embed job endpoint allows users to view all embed jobs history for that specific user.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ListEmbedJobResponse>> ListAsResponseAsync(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}