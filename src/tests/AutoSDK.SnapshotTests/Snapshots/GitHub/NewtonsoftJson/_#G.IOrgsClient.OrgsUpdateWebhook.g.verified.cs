//HintName: G.IOrgsClient.OrgsUpdateWebhook.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update an organization webhook<br/>
        /// Updates a webhook configured in an organization. When you update a webhook,<br/>
        /// the `secret` will be overwritten. If you previously had a `secret` set, you must<br/>
        /// provide the same `secret` or set a new `secret` or the secret will be removed. If<br/>
        /// you are only updating individual webhook `config` properties, use "[Update a webhook<br/>
        /// configuration for an organization](/rest/orgs/webhooks#update-a-webhook-configuration-for-an-organization)".<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit<br/>
        /// webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsUpdateWebhookAsync(
            string org,
            int hookId,
            global::G.OrgsUpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an organization webhook<br/>
        /// Updates a webhook configured in an organization. When you update a webhook,<br/>
        /// the `secret` will be overwritten. If you previously had a `secret` set, you must<br/>
        /// provide the same `secret` or set a new `secret` or the secret will be removed. If<br/>
        /// you are only updating individual webhook `config` properties, use "[Update a webhook<br/>
        /// configuration for an organization](/rest/orgs/webhooks#update-a-webhook-configuration-for-an-organization)".<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit<br/>
        /// webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
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
        /// <param name="name">
        /// Example: "web"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsUpdateWebhookAsync(
            string org,
            int hookId,
            global::G.OrgsUpdateWebhookRequestConfig? config = default,
            global::System.Collections.Generic.IList<string>? events = default,
            bool? active = true,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}