//HintName: G.IProductClient.GetProductsByNames.g.cs
#nullable enable

namespace G
{
    public partial interface IProductClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="productNames"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProductForListResponseDto>> GetProductsByNamesAsync(
            global::System.Collections.Generic.IList<string>? productNames = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}