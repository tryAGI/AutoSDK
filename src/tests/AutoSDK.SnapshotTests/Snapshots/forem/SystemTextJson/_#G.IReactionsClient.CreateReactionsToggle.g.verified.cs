//HintName: G.IReactionsClient.CreateReactionsToggle.g.cs
#nullable enable

namespace G
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// toggle reaction<br/>
        /// This endpoint allows the client to toggle the user's reaction to a specified reactable (eg, Article, Comment, or User). For examples:<br/>
        ///         * "Like"ing an Article will create a new "like" Reaction from the user for that Articles<br/>
        ///         * "Like"ing that Article a second time will remove the "like" from the user
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateReactionsToggleAsync(
            global::G.CreateReactionsToggleCategory category,
            int reactableId,
            global::G.CreateReactionsToggleReactableType reactableType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}