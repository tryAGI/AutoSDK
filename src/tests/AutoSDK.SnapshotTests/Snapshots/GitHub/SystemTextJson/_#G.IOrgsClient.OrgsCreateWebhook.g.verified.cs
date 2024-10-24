//HintName: G.IOrgsClient.OrgsCreateWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create an organization webhook<br/>
        /// Create a hook that posts payloads in JSON format.<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or<br/>
        /// edit webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsCreateWebhookAsync(
            string org,
            global::G.OrgsCreateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an organization webhook<br/>
        /// Create a hook that posts payloads in JSON format.<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or<br/>
        /// edit webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Must be passed as "web".
        /// </param>
        /// <param name="config">
        /// Key/value pairs to provide settings for this webhook.
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. Set to `["*"]` to receive all possible events.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsCreateWebhookAsync(
            string org,
            string name,
            global::G.OrgsCreateWebhookRequestConfig config,
            global::System.Collections.Generic.IList<string>? events = default,
            bool? active = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}