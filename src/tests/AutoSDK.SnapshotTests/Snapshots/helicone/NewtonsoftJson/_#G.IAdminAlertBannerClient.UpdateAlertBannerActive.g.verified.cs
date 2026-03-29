//HintName: G.IAdminAlertBannerClient.UpdateAlertBannerActive.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminAlertBannerClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultVoidString> UpdateAlertBannerActiveAsync(

            global::G.UpdateAlertBannerActiveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="active"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultVoidString> UpdateAlertBannerActiveAsync(
            bool active,
            double id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}