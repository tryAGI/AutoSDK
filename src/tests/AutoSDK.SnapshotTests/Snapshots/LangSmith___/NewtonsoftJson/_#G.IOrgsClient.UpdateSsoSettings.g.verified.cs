//HintName: G.IOrgsClient.UpdateSsoSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO provider settings defaults for the current organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SSOProvider> UpdateSsoSettingsAsync(
            global::System.Guid id,
            global::G.SSOSettingsUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO provider settings defaults for the current organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SSOProvider> UpdateSsoSettingsAsync(
            global::System.Guid id,
            global::System.Guid? defaultWorkspaceRoleId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? defaultWorkspaceIds = default,
            string? metadataUrl = default,
            string? metadataXml = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}