//HintName: G.IAccountClient.GetAccountBilling.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Account Billing<br/>
        /// Returns billing information for the authenticated account. Use the `expand`<br/>
        /// parameter to include additional details.<br/>
        /// **Expandable Fields:**<br/>
        /// - `credits` — Current credit balance and currency<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor available credit balance programmatically<br/>
        /// - Display balance in custom dashboards
        /// </summary>
        /// <param name="expand">
        /// Data to include in the response. Use 'credits' to include current credit balance.<br/>
        /// Example: credits
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAccountBillingResponse> GetAccountBillingAsync(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}