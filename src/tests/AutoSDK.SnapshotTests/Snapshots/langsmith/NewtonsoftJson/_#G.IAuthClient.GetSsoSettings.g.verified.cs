//HintName: G.IAuthClient.GetSsoSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get Sso Settings<br/>
        /// Get SSO provider settings from login slug.
        /// </summary>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SSOProviderSlim>> GetSsoSettingsAsync(
            string ssoLoginSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}