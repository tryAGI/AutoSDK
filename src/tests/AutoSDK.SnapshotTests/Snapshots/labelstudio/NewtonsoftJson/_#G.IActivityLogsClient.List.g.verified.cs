//HintName: G.IActivityLogsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityLogsClient
    {
        /// <summary>
        /// ✨ Get activity logs<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve activity logs filtered by workspace, project, user, HTTP method, date range or search query.
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="method">
        /// Default Value: all
        /// </param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="project"></param>
        /// <param name="search"></param>
        /// <param name="startDate"></param>
        /// <param name="user"></param>
        /// <param name="workspace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ActivityLogResponse>> ListAsync(
            string? endDate = default,
            global::G.ApiActivityLogsListMethod? method = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            int? project = default,
            string? search = default,
            string? startDate = default,
            int? user = default,
            int? workspace = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}