//HintName: G.IOrderClient.ActivateOrder.g.cs
#nullable enable

namespace G
{
    public partial interface IOrderClient
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
        global::System.Threading.Tasks.Task<global::G.OrderForActivateResponseDto> ActivateOrderAsync(
            global::G.OrderForActivateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="walletFundingRequest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrderForActivateResponseDto> ActivateOrderAsync(
            string? currentCulture = default,
            long? id = default,
            bool? walletFundingRequest = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}