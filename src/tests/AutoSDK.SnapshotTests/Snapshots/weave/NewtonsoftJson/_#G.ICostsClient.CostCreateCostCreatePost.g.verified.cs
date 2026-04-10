//HintName: G.ICostsClient.CostCreateCostCreatePost.g.cs
#nullable enable

namespace G
{
    public partial interface ICostsClient
    {
        /// <summary>
        /// Cost Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CostCreateRes> CostCreateCostCreatePostAsync(

            global::G.CostCreateReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cost Create
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="costs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CostCreateRes> CostCreateCostCreatePostAsync(
            string projectId,
            global::System.Collections.Generic.Dictionary<string, global::G.CostCreateInput> costs,
            string? wbUserId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}