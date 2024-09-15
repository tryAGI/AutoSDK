//HintName: G.IActivityClient.ActivitySetRepoSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Set a repository subscription<br/>
        /// If you would like to watch a repository, set `subscribed` to `true`. If you would like to ignore notifications made within a repository, set `ignored` to `true`. If you would like to stop watching a repository, [delete the repository's subscription](https://docs.github.com/rest/activity/watching#delete-a-repository-subscription) completely.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositorySubscription> ActivitySetRepoSubscriptionAsync(
            string owner,
            string repo,
            global::G.ActivitySetRepoSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a repository subscription<br/>
        /// If you would like to watch a repository, set `subscribed` to `true`. If you would like to ignore notifications made within a repository, set `ignored` to `true`. If you would like to stop watching a repository, [delete the repository's subscription](https://docs.github.com/rest/activity/watching#delete-a-repository-subscription) completely.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="subscribed">
        /// Determines if notifications should be received from this repository.
        /// </param>
        /// <param name="ignored">
        /// Determines if all notifications should be blocked from this repository.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositorySubscription> ActivitySetRepoSubscriptionAsync(
            string owner,
            string repo,
            bool subscribed = default,
            bool ignored = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}