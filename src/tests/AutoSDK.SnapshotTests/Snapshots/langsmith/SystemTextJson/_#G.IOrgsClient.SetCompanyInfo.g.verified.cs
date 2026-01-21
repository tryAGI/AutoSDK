//HintName: G.IOrgsClient.SetCompanyInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Set Company Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetCompanyInfoAsync(
            global::G.StripeBusinessInfoInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Company Info
        /// </summary>
        /// <param name="companyInfo"></param>
        /// <param name="taxId"></param>
        /// <param name="invoiceEmail"></param>
        /// <param name="isBusiness">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetCompanyInfoAsync(
            global::G.StripeBusinessBillingInfo? companyInfo = default,
            global::G.StripeTaxId? taxId = default,
            string? invoiceEmail = default,
            bool? isBusiness = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}