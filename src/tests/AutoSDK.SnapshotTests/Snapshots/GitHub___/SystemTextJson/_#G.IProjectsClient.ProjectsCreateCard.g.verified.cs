//HintName: G.IProjectsClient.ProjectsCreateCard.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a project card
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectCard> ProjectsCreateCardAsync(
            int columnId,
            global::G.OneOf<global::G.ProjectsCreateCardRequestVariant1, global::G.ProjectsCreateCardRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a project card
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectCard> ProjectsCreateCardAsync(
            int columnId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}