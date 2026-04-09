//HintName: G.IOrganizationsClient.Assign.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Bulk assign tags to organization members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Assign tags to multiple organization members in bulk.
        /// </summary>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="role"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiOrganizationsMemberTagsAssignmentsCreateResponse> AssignAsync(
            int id,

            global::G.BulkOrganizationMemberTagAssignmentRequest request,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            bool? isDeleted = default,
            string? role = default,
            string? tags = default,
            string? userLastActivityGte = default,
            string? userLastActivityLte = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Bulk assign tags to organization members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Assign tags to multiple organization members in bulk.
        /// </summary>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="role"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="all">
        /// If true, assign tags to all organization members. If false, assign tags to the provided users.
        /// </param>
        /// <param name="excluded">
        /// List of user IDs to exclude from the assignment.
        /// </param>
        /// <param name="included">
        /// List of user IDs to include in the assignment.
        /// </param>
        /// <param name="overwrite">
        /// If true, replace all existing tag assignments for each user with the provided ones. If false, only add new assignments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestTags">
        /// List of tag IDs to assign.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiOrganizationsMemberTagsAssignmentsCreateResponse> AssignAsync(
            int id,
            bool all,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            bool? isDeleted = default,
            string? role = default,
            string? tags = default,
            string? userLastActivityGte = default,
            string? userLastActivityLte = default,
            global::System.Collections.Generic.IList<int>? excluded = default,
            global::System.Collections.Generic.IList<int>? included = default,
            bool? overwrite = default,
            global::System.Collections.Generic.IList<int>? requestTags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}