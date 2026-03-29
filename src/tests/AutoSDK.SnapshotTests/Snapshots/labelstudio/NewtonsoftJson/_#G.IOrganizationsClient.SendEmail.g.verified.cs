//HintName: G.IOrganizationsClient.SendEmail.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Send email with invite<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Send email with invite to organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SendEmailAsync(

            global::G.SendInviteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Send email with invite<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Send email with invite to organization
        /// </summary>
        /// <param name="emails">
        /// Email addresses
        /// </param>
        /// <param name="projects">
        /// Project IDs to grant access to
        /// </param>
        /// <param name="role">
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="workspaces">
        /// Workspace IDs to grant access to
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendEmailAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::G.Role9e7Enum role,
            global::System.Collections.Generic.IList<int>? projects = default,
            global::System.Collections.Generic.IList<int>? workspaces = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}