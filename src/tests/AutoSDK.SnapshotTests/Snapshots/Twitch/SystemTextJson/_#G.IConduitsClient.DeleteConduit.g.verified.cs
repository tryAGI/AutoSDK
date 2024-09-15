//HintName: G.IConduitsClient.DeleteConduit.g.cs
#nullable enable

namespace G
{
    public partial interface IConduitsClient
    {
        /// <summary>
        /// NEW Deletes a specified conduit.<br/>
        /// NEW Deletes a specified [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events/). Note that it may take some time for Eventsub subscriptions on a deleted [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to show as disabled when calling [Get Eventsub Subscriptions](https://dev.twitch.tv/docs/api/reference/#get-eventsub-subscriptions).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteConduitAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}