//HintName: G.OrgsClient.OrgsUpdateWebhook.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Update an organization webhook
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrgHook> OrgsUpdateWebhookAsync(
            string org,
            int hookId,
            OrgsUpdateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/hooks/{hookId}", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<OrgHook?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an organization webhook
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="config"></param>
        /// <param name="events"></param>
        /// <param name="active"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrgHook> OrgsUpdateWebhookAsync(
            string org,
            int hookId,
            OrgsUpdateWebhookRequestConfig? config = default,
            global::System.Collections.Generic.IList<string?>? events = default,
            bool active = true,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsUpdateWebhookRequest
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