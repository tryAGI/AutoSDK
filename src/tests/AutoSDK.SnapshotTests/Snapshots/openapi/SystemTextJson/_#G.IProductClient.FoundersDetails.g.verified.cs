//HintName: G.IProductClient.FoundersDetails.g.cs
#nullable enable

namespace G
{
    public partial interface IProductClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProductFoundersForListResponseDto> FoundersDetailsAsync(
            global::G.ProductFoundersForListRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProductFoundersForListResponseDto> FoundersDetailsAsync(
            string? currentCulture = default,
            long? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}