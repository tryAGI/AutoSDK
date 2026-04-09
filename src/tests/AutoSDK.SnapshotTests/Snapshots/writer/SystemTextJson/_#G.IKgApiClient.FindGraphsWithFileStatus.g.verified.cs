//HintName: G.IKgApiClient.FindGraphsWithFileStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// List graphs<br/>
        /// Retrieve a list of Knowledge Graphs.
        /// </summary>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GraphsResponse> FindGraphsWithFileStatusAsync(
            global::G.FindGraphsWithFileStatusOrder? order = default,
            global::System.Guid? before = default,
            global::System.Guid? after = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}