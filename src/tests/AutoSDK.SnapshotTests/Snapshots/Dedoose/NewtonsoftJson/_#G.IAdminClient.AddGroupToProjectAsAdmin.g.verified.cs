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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddGroupToProjectAsAdminAsync(
            global::G.AddGroupToProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddGroupToProject<br/>
        /// AddGroupToProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupTitle"></param>
        /// <param name="groupACLId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddGroupToProjectAsAdminAsync(
            global::System.Guid projectId,
            string groupTitle,
            global::System.Guid groupACLId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}