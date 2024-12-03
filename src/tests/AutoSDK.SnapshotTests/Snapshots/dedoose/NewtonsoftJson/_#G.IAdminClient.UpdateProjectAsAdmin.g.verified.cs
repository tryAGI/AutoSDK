//HintName: G.IAdminClient.UpdateProjectAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// UpdateProject<br/>
        /// UpdateProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateProjectAsAdminAsync(
            global::G.UpdateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateProject<br/>
        /// UpdateProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="adminId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateProjectAsAdminAsync(
            global::System.Guid projectId,
            string title,
            global::System.Guid adminId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}