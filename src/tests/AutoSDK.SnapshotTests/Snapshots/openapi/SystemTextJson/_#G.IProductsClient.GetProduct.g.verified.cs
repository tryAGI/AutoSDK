//HintName: G.IProductsClient.GetProduct.g.cs
#nullable enable

namespace G
{
    public partial interface IProductsClient
    {
        /// <summary>
        /// Get Product<br/>
        /// Returns single product by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProductDto> GetProductAsync(
            long id,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}