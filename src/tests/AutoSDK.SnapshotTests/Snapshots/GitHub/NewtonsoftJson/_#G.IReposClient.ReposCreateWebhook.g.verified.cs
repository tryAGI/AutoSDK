//HintName: G.IReposClient.ReposCreateWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a repository webhook<br/>
        /// Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks can<br/>
        /// share the same `config` as long as those webhooks do not have any `events` that overlap.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Hook> ReposCreateWebhookAsync(
            string owner,
            string repo,
            global::G.ReposCreateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a repository webhook<br/>
        /// Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks can<br/>
        /// share the same `config` as long as those webhooks do not have any `events` that overlap.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name">
        /// Use `web` to create a webhook. Default: `web`. This parameter only accepts the value `web`.
        /// </param>
        /// <param name="config">
        /// Key/value pairs to provide settings for this webhook.
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Hook> ReposCreateWebhookAsync(
            string owner,
            string repo,
            string? name = default,
            global::G.ReposCreateWebhookRequestConfig? config = default,
            global::System.Collections.Generic.IList<string>? events = default,
            bool active = true,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}