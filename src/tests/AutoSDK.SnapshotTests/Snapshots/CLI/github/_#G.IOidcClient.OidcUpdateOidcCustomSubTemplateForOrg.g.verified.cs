//HintName: G.IOidcClient.OidcUpdateOidcCustomSubTemplateForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IOidcClient
    {
        /// <summary>
        /// Set the customization template for an OIDC subject claim for an organization<br/>
        /// Creates or updates the customization template for an OpenID Connect (OIDC) subject claim.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> OidcUpdateOidcCustomSubTemplateForOrgAsync(
            string org,
            global::G.OidcCustomSub request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the customization template for an OIDC subject claim for an organization<br/>
        /// Creates or updates the customization template for an OpenID Connect (OIDC) subject claim.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> OidcUpdateOidcCustomSubTemplateForOrgAsync(
            string org,
            global::System.Collections.Generic.IList<string> includeClaimKeys,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}