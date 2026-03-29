//HintName: G.IAdminAlertBannerClient.GetAlertBanners.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminAlertBannerClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayString> GetAlertBannersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}