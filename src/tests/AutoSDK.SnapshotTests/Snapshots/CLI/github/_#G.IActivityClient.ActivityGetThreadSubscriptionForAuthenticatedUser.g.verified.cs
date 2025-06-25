//HintName: G.IActivityClient.ActivityGetThreadSubscriptionForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get a thread subscription for the authenticated user<br/>
        /// This checks to see if the current user is subscribed to a thread. You can also [get a repository subscription](https://docs.github.com/rest/activity/watching#get-a-repository-subscription).<br/>
        /// Note that subscriptions are only generated if a user is participating in a conversation--for example, they've replied to the thread, were **@mentioned**, or manually subscribe to a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ThreadSubscription> ActivityGetThreadSubscriptionForAuthenticatedUserAsync(
            int threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}