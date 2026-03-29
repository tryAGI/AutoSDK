//HintName: G.IProjectRolesClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectRolesClient
    {
        /// <summary>
        /// ✨ List project roles for current user<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        ///         List project roles for requested IDs for the current user<br/>
        ///         
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProjectRole>> ListAsync(
            int? ids = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}