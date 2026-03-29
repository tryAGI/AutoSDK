//HintName: G.ISubpackageEntityCollectionsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsClient
    {
        /// <summary>
        /// List entity collections<br/>
        /// This method returns a list of the entity collections in your account.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="name"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EntityCollectionsListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? name = default,
            global::G.EntityCollectionsGetParametersSortBy? sortBy = default,
            string? sortOption = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}