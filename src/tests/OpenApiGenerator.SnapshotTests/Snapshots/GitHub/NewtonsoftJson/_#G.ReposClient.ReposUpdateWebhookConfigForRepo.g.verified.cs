//HintName: G.ReposClient.ReposUpdateWebhookConfigForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a webhook configuration for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<WebhookConfig> ReposUpdateWebhookConfigForRepoAsync(
            string owner,
            string repo,
            int hookId,
            ReposUpdateWebhookConfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/hooks/{hookId}/config", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<WebhookConfig?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a webhook configuration for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="url"></param>
        /// <param name="contentType"></param>
        /// <param name="secret"></param>
        /// <param name="insecureSsl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<WebhookConfig> ReposUpdateWebhookConfigForRepoAsync(
            string owner,
            string repo,
            int hookId,
            string? url = default,
            string? contentType = default,
            string? secret = default,
            global::System.OneOf<string?, double> insecureSsl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateWebhookConfigForRepoRequest
            {
                Url = url,
                ContentType = contentType,
                Secret = secret,
                InsecureSsl = insecureSsl,
            };

            return await ReposUpdateWebhookConfigForRepoAsync(
                owner: owner,
                repo: repo,
                hookId: hookId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}