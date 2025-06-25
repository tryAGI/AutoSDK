//HintName: G.IProjectsClient.ProjectsDeleteCard.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project card<br/>
        /// Deletes a project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsDeleteCardAsync(
            int cardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}