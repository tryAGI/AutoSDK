//HintName: IXSocial.IIXSocialClient.ListCharges.g.cs
#nullable enable

namespace IXSocial
{
    public partial interface IIXSocialClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::IXSocial.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::IXSocial.ListChargesResponse> ListChargesAsync(
            global::IXSocial.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}