//HintName: G.IProjectsClient.DeleteProjectServiceAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Deletes a service account from the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectServiceAccountDeleteResponse> DeleteProjectServiceAccountAsync(
            string projectId,
            string serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}