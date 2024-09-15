//HintName: G.IBillingClient.UpcomingInvoice.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Upcoming Invoice
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUpcomingInvoice> UpcomingInvoiceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}