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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse> SetCompanyInfoAsync(
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
        global::System.Threading.Tasks.Task<global::G.SetCompanyInfoApiV1OrgsCurrentBusinessInfoPostResponse> SetCompanyInfoAsync(
            global::G.AnyOf<global::G.StripeBusinessBillingInfo, object>? companyInfo = default,
            global::G.AnyOf<global::G.StripeTaxId, object>? taxId = default,
            global::G.AnyOf<string, object>? invoiceEmail = default,
            bool? isBusiness = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}