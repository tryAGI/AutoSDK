//HintName: G.IOrderClient.GetOrderForInvoice.g.cs
#nullable enable

namespace G
{
    public partial interface IOrderClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrderForInvoiceResponseDto> GetOrderForInvoiceAsync(
            long? orderId = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}