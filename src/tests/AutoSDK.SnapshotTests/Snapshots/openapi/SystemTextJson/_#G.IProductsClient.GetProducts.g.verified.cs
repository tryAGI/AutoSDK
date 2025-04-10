//HintName: G.IProductsClient.GetProducts.g.cs
#nullable enable

namespace G
{
    public partial interface IProductsClient
    {
        /// <summary>
        /// Get Products<br/>
        /// Returns all products.
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProductDto>> GetProductsAsync(
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}