//HintName: G.IProjectsClient.ListProjectsApiV1ProjectsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List Projects<br/>
        /// List projects or get one by name
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectName"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Project>> ListProjectsApiV1ProjectsGetAsync(
            global::System.Guid? organizationId = default,
            string? projectName = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}