//HintName: G.ReposClient.ReposUpdateWebhook.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a repository webhook
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Hook> ReposUpdateWebhookAsync(
            string owner,
            string repo,
            int hookId,
            ReposUpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/hooks/{hookId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Hook?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository webhook
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="config"></param>
        /// <param name="events"></param>
        /// <param name="addEvents"></param>
        /// <param name="removeEvents"></param>
        /// <param name="active"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Hook> ReposUpdateWebhookAsync(
            string owner,
            string repo,
            int hookId,
            WebhookConfig? config = default,
            global::System.Collections.Generic.IList<string?>? events = default,
            global::System.Collections.Generic.IList<string?>? addEvents = default,
            global::System.Collections.Generic.IList<string?>? removeEvents = default,
            bool active = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateWebhookRequest
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