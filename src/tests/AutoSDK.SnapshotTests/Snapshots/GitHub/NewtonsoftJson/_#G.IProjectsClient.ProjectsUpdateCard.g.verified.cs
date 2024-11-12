//HintName: G.IProjectsClient.ProjectsUpdateCard.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            global::G.ProjectsUpdateCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="note">
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </param>
        /// <param name="archived">
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            string? note = default,
            bool? archived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}