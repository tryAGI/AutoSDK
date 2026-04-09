//HintName: G.IDatasetsClient.ApiDatasetsMembersList.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get datasets members<br/>
        /// Retrieve the members for a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DatasetMember>> ApiDatasetsMembersListAsync(
            int id,
            string? ordering = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}