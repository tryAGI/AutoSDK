//HintName: G.IProjectsClient.AddProjectMember.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add member to project<br/>
        /// Add a new member to a specific project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddProjectMemberResponse> AddProjectMemberAsync(
            string orgId,
            string projectId,

            global::G.AddProjectMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add member to project<br/>
        /// Add a new member to a specific project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="email">
        /// Email of the member to be added.
        /// </param>
        /// <param name="role">
        /// Role of the member in the project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddProjectMemberResponse> AddProjectMemberAsync(
            string orgId,
            string projectId,
            string email,
            string role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}