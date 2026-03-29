//HintName: G.IApi.ShoppingSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Shopping Search<br/>
        /// Search Google Shopping for product listings and prices.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ShoppingSearchResponse> ShoppingSearchAsync(

            global::G.ShoppingSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Shopping Search<br/>
        /// Search Google Shopping for product listings and prices.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ShoppingSearchResponse> ShoppingSearchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}