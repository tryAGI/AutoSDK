//HintName: G.IGroupsClient.CreateGroup.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Create Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="xProject">
        /// The project slug to associate with the group (cloud only).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Group> CreateGroupAsync(

            global::G.GroupCreate request,
            string? xProject = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="xProject">
        /// The project slug to associate with the group (cloud only).
        /// </param>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="managerConfig">
        /// Default Value: {"manager_type":"round_robin"}
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Group> CreateGroupAsync(
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            string? xProject = default,
            global::G.ManagerConfig? managerConfig = default,
            string? projectId = default,
            bool? hidden = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}