//HintName: G.IGroupsClient.ModifyGroup.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Modify Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="xProject">
        /// The project slug to associate with the group (cloud only).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Group> ModifyGroupAsync(
            string groupId,

            global::G.GroupUpdate request,
            string? xProject = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="xProject">
        /// The project slug to associate with the group (cloud only).
        /// </param>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="managerConfig"></param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Group> ModifyGroupAsync(
            string groupId,
            string? xProject = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            string? description = default,
            global::G.ManagerConfigVariant1? managerConfig = default,
            string? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}