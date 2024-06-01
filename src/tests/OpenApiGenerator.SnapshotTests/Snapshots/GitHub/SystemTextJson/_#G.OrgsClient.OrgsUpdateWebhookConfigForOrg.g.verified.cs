//HintName: G.OrgsClient.OrgsUpdateWebhookConfigForOrg.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Update a webhook configuration for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<WebhookConfig> OrgsUpdateWebhookConfigForOrgAsync(
            string org,
            int hookId,
            OrgsUpdateWebhookConfigForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/hooks/{hookId}/config", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<WebhookConfig?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a webhook configuration for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="url"></param>
        /// <param name="contentType"></param>
        /// <param name="secret"></param>
        /// <param name="insecureSsl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<WebhookConfig> OrgsUpdateWebhookConfigForOrgAsync(
            string org,
            int hookId,
            string? url = default,
            string? contentType = default,
            string? secret = default,
            global::System.OneOf<string?, double> insecureSsl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsUpdateWebhookConfigForOrgRequest
            {
                Url = url,
                ContentType = contentType,
                Secret = secret,
                InsecureSsl = insecureSsl,
            };

            return await OrgsUpdateWebhookConfigForOrgAsync(
                org: org,
                hookId: hookId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}