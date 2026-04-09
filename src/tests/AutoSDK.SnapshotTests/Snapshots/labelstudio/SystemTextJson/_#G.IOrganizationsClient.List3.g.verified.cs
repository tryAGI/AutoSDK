//HintName: G.IOrganizationsClient.List3.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Get organization members/roles<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve a list of all users and roles in a specific organization.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedLseOrganizationMemberListList> List3Async(
            int id,
            bool? contributedToProjects = default,
            int? excludeProjectId = default,
            int? excludeWorkspaceId = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}