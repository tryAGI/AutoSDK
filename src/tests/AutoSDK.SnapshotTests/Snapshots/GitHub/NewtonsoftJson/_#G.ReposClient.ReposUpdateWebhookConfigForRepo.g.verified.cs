//HintName: G.ReposClient.ReposUpdateWebhookConfigForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateWebhookConfigForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int hookId,
            global::G.ReposUpdateWebhookConfigForRepoRequest request);
        partial void PrepareReposUpdateWebhookConfigForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int hookId,
            global::G.ReposUpdateWebhookConfigForRepoRequest request);
        partial void ProcessReposUpdateWebhookConfigForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateWebhookConfigForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.WebhookConfig> ReposUpdateWebhookConfigForRepoAsync(
            string owner,
            string repo,
            int hookId,
            global::G.ReposUpdateWebhookConfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposUpdateWebhookConfigForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                hookId: ref hookId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/hooks/{hookId}/config",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposUpdateWebhookConfigForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                hookId: hookId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposUpdateWebhookConfigForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReposUpdateWebhookConfigForRepoResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.WebhookConfig.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    await global::G.WebhookConfig.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

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
        public async global::System.Threading.Tasks.Task<global::G.WebhookConfig> ReposUpdateWebhookConfigForRepoAsync(
            string owner,
            string repo,
            int hookId,
            string? url = default,
            string? contentType = default,
            string? secret = default,
            global::G.WebhookConfigInsecureSsl? insecureSsl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ReposUpdateWebhookConfigForRepoRequest
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}