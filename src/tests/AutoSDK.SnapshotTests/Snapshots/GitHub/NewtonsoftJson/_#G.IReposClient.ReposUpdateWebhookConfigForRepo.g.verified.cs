//HintName: G.IReposClient.ReposUpdateWebhookConfigForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update a webhook configuration for a repository<br/>
        /// Updates the webhook configuration for a repository. To update more information about the webhook, including the `active` state and `events`, use "[Update a repository webhook](/rest/webhooks/repos#update-a-repository-webhook)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:repo_hook` or `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookConfig> ReposUpdateWebhookConfigForRepoAsync(
            string owner,
            string repo,
            int hookId,
            global::G.ReposUpdateWebhookConfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a webhook configuration for a repository<br/>
        /// Updates the webhook configuration for a repository. To update more information about the webhook, including the `active` state and `events`, use "[Update a repository webhook](/rest/webhooks/repos#update-a-repository-webhook)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:repo_hook` or `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="url">
        /// The URL to which the payloads will be delivered.<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="contentType">
        /// The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.<br/>
        /// Example: "json"
        /// </param>
        /// <param name="secret">
        /// If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).<br/>
        /// Example: "********"
        /// </param>
        /// <param name="insecureSsl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookConfig> ReposUpdateWebhookConfigForRepoAsync(
            string owner,
            string repo,
            int hookId,
            string? url = default,
            string? contentType = default,
            string? secret = default,
            global::G.WebhookConfigInsecureSsl? insecureSsl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}