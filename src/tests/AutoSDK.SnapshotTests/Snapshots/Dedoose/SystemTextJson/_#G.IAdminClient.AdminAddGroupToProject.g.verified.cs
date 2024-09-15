//HintName: G.IAdminClient.AdminAddGroupToProject.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddGroupToProject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="groupTitle"></param>
        /// <param name="groupACLId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminAddGroupToProjectResponse> AdminAddGroupToProjectAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? groupTitle = default,
            global::System.Guid groupACLId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}