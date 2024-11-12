//HintName: G.IProjectsClient.ProjectsMoveCard.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Move a project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsMoveCardResponse> ProjectsMoveCardAsync(
            int cardId,
            global::G.ProjectsMoveCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Move a project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="position">
        /// The position of the card in a column. Can be one of: `top`, `bottom`, or `after:&lt;card_id&gt;` to place after the specified card.<br/>
        /// Example: bottom
        /// </param>
        /// <param name="columnId">
        /// The unique identifier of the column the card should be moved to<br/>
        /// Example: 42
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsMoveCardResponse> ProjectsMoveCardAsync(
            int cardId,
            string position,
            int? columnId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}