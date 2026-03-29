//HintName: G.IDocumentsClient.DocumentList.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// list<br/>
        /// lookup all documents across all resources which are currently on GroundX<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="filter"></param>
        /// <param name="sort">
        /// The attribute to use to sort results
        /// </param>
        /// <param name="sortOrder">
        /// The order in which to sort results
        /// </param>
        /// <param name="status"></param>
        /// <param name="nextToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentListResponse> DocumentListAsync(
            int? n = default,
            string? filter = default,
            global::G.Sort? sort = default,
            global::G.SortOrder? sortOrder = default,
            global::G.ProcessingStatus? status = default,
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}