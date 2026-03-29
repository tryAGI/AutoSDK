//HintName: G.IWorkspaces2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaces2Client
    {
        /// <summary>
        /// ✨ List workspaces<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// List all workspaces for your organization. Workspaces in Label Studio let you organize your projects and users into separate spaces. This is useful for managing different teams, departments, or projects within your organization. For more information, see the [Workspaces documentation](https://docs.humansignal.com/workspaces).
        /// </summary>
        /// <param name="includeAllWorkspaces"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPersonal"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Workspace>> ListAsync(
            bool? includeAllWorkspaces = default,
            bool? isArchived = default,
            bool? isPersonal = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}