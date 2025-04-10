//HintName: G.IOrdersClient.CheckUpgradeToMembership365.g.cs
#nullable enable

namespace G
{
    public partial interface IOrdersClient
    {
        /// <summary>
        /// Check Upgrade To Membership 365<br/>
        /// Checks if the user can upgrade to Membership 365 with current order details and return details if not.
        /// </summary>
        /// <param name="customPrice">
        /// Default Value: 0
        /// </param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckUpgradeToMembership365ResponseDto> CheckUpgradeToMembership365Async(
            double? customPrice = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}