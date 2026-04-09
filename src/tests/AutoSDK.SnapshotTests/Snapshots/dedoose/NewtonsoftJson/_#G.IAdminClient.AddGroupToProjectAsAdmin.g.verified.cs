//HintName: G.IAdminClient.AddGroupToProjectAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddGroupToProject<br/>
        /// AddGroupToProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddGroupToProjectAsAdminAsync(

            global::G.AddGroupToProjectRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AddGroupToProject<br/>
        /// AddGroupToProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupTitle"></param>
        /// <param name="groupACLId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddGroupToProjectAsAdminAsync(
            global::System.Guid projectId,
            string groupTitle,
            global::System.Guid groupACLId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}