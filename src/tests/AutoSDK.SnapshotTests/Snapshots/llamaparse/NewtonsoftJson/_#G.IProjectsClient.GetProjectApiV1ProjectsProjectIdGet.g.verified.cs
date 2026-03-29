//HintName: G.IProjectsClient.GetProjectApiV1ProjectsProjectIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project<br/>
        /// Get a project by ID.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> GetProjectApiV1ProjectsProjectIdGetAsync(
            global::System.Guid? projectId,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}