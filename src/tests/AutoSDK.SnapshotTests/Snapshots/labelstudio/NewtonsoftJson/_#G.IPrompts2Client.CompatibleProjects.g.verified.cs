//HintName: G.IPrompts2Client.CompatibleProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ List projects compatible with prompt<br/>
        /// Retrieve a list of compatible project for prompt.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectType">
        /// Default Value: TextClassification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedAllRolesProjectListList> CompatibleProjectsAsync(
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::G.ApiPromptsCompatibleProjectsListProjectType? projectType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}