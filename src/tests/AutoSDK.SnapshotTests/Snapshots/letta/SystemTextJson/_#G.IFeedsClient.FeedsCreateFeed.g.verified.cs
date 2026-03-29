//HintName: G.IFeedsClient.FeedsCreateFeed.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Create Feed<br/>
        /// Create a new feed in a project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsCreateFeedResponse> FeedsCreateFeedAsync(

            global::G.FeedsCreateFeedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Feed<br/>
        /// Create a new feed in a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsCreateFeedResponse> FeedsCreateFeedAsync(
            string projectId,
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}