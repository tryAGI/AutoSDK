//HintName: G.IProjectsClient.Post.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// ✨ Bulk assign project members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Assign project members in bulk.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsMembersBulkCreateResponse> PostAsync(
            int id,

            global::G.ProjectMemberBulkAssignRequest request,
            string? lastActivityGte = default,
            string? lastActivityLte = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Bulk assign project members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Assign project members in bulk.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="all">
        /// Apply to all project members
        /// </param>
        /// <param name="excluded">
        /// Excluded user IDs
        /// </param>
        /// <param name="included">
        /// Included user IDs
        /// </param>
        /// <param name="roles">
        /// Member roles
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsMembersBulkCreateResponse> PostAsync(
            int id,
            bool all,
            string? lastActivityGte = default,
            string? lastActivityLte = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            global::System.Collections.Generic.IList<int>? excluded = default,
            global::System.Collections.Generic.IList<int>? included = default,
            global::System.Collections.Generic.IList<global::G.ProjectMemberBulkAssignRolesRequest>? roles = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}