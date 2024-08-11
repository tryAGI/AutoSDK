//HintName: G.OrgsClient.OrgsUpdateWebhook.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsUpdateWebhookArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int hookId,
            global::G.OrgsUpdateWebhookRequest request);
        partial void PrepareOrgsUpdateWebhookRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int hookId,
            global::G.OrgsUpdateWebhookRequest request);
        partial void ProcessOrgsUpdateWebhookResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsUpdateWebhookResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsUpdateWebhookAsync(
            string org,
            int hookId,
            global::G.OrgsUpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsUpdateWebhookArguments(
                httpClient: _httpClient,
                org: ref org,
                hookId: ref hookId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/hooks/{hookId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsUpdateWebhookRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                hookId: hookId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsUpdateWebhookResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsUpdateWebhookResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrgHook?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

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
        public async global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsUpdateWebhookAsync(
            string org,
            int hookId,
            global::G.OrgsUpdateWebhookRequestConfig? config = default,
            global::System.Collections.Generic.IList<string>? events = default,
            bool active = true,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsUpdateWebhookRequest
            {
                Config = config,
                Events = events,
                Active = active,
                Name = name,
            };

            return await OrgsUpdateWebhookAsync(
                org: org,
                hookId: hookId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}