//HintName: G.ReposClient.ReposUpdateWebhook.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateWebhookArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int hookId,
            global::G.ReposUpdateWebhookRequest request);
        partial void PrepareReposUpdateWebhookRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int hookId,
            global::G.ReposUpdateWebhookRequest request);
        partial void ProcessReposUpdateWebhookResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateWebhookResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a repository webhook<br/>
        /// Updates a webhook configured in a repository. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use "[Update a webhook configuration for a repository](/rest/webhooks/repo-config#update-a-webhook-configuration-for-a-repository)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Hook> ReposUpdateWebhookAsync(
            string owner,
            string repo,
            int hookId,
            global::G.ReposUpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposUpdateWebhookArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                hookId: ref hookId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/hooks/{hookId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposUpdateWebhookRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                hookId: hookId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposUpdateWebhookResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposUpdateWebhookResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Hook?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository webhook<br/>
        /// Updates a webhook configured in a repository. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use "[Update a webhook configuration for a repository](/rest/webhooks/repo-config#update-a-webhook-configuration-for-a-repository)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="config">
        /// Configuration object of the webhook
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="addEvents">
        /// Determines a list of events to be added to the list of events that the Hook triggers for.
        /// </param>
        /// <param name="removeEvents">
        /// Determines a list of events to be removed from the list of events that the Hook triggers for.
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Hook> ReposUpdateWebhookAsync(
            string owner,
            string repo,
            int hookId,
            global::G.WebhookConfig? config = default,
            global::System.Collections.Generic.IList<string>? events = default,
            global::System.Collections.Generic.IList<string>? addEvents = default,
            global::System.Collections.Generic.IList<string>? removeEvents = default,
            bool active = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposUpdateWebhookRequest
            {
                Config = config,
                Events = events,
                AddEvents = addEvents,
                RemoveEvents = removeEvents,
                Active = active,
            };

            return await ReposUpdateWebhookAsync(
                owner: owner,
                repo: repo,
                hookId: hookId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}