//HintName: G.ISsoClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ISsoClient
    {
        /// <summary>
        /// ✨ Update SAML2 Settings<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update SAML2 settings for the currently active organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SamlSettingsUpdate> UpdateAsync(

            global::G.SamlSettingsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update SAML2 Settings<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update SAML2 settings for the currently active organization.
        /// </summary>
        /// <param name="domain">
        /// Organization web domain or domains; use comma separated list with no spaces for multiple. Example:labelstud.io,humansignal.comIMPORTANT: DO NOT PUT COMMON DOMAINS LIKE GMAIL.COM, YAHOO.COM, ETC. IN THIS FIELD
        /// </param>
        /// <param name="idpProvider">
        /// Identity Provider preset key (e.g. okta, azure, google, custom)
        /// </param>
        /// <param name="mappingEmail">
        /// Mapping attributes: user email from SAML request
        /// </param>
        /// <param name="mappingFirstName">
        /// Mapping attributes: user first name from SAML request
        /// </param>
        /// <param name="mappingGroups">
        /// Mapping attributes: groups attribute for user mapping to workspaces and roles
        /// </param>
        /// <param name="mappingLastName">
        /// Mapping attributes: user last name from SAML request
        /// </param>
        /// <param name="metadataUrl">
        /// URL SAML metadata from IdP
        /// </param>
        /// <param name="metadataXml">
        /// Metadata XML file
        /// </param>
        /// <param name="projectsGroups">
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </param>
        /// <param name="rolesGroups">
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </param>
        /// <param name="workspacesGroups">
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SamlSettingsUpdate> UpdateAsync(
            string? domain = default,
            string? idpProvider = default,
            string? mappingEmail = default,
            string? mappingFirstName = default,
            string? mappingGroups = default,
            string? mappingLastName = default,
            string? metadataUrl = default,
            string? metadataXml = default,
            global::System.Collections.Generic.IList<global::G.ProjectGroupRequest>? projectsGroups = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? rolesGroups = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? workspacesGroups = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}