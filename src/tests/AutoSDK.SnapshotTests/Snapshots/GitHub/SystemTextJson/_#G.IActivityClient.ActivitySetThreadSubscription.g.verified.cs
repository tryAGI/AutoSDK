//HintName: G.IActivityClient.ActivitySetThreadSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Set a thread subscription<br/>
        /// If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.<br/>
        /// You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.<br/>
        /// Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/activity/notifications#delete-a-thread-subscription) endpoint.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ThreadSubscription> ActivitySetThreadSubscriptionAsync(
            int threadId,
            global::G.ActivitySetThreadSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a thread subscription<br/>
        /// If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.<br/>
        /// You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.<br/>
        /// Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/activity/notifications#delete-a-thread-subscription) endpoint.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="ignored">
        /// Whether to block all notifications from a thread.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ThreadSubscription> ActivitySetThreadSubscriptionAsync(
            int threadId,
            bool? ignored = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}