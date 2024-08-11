//HintName: G.AppsClient.AppsCreateFromManifest.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        partial void PrepareAppsCreateFromManifestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string code);
        partial void PrepareAppsCreateFromManifestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string code);
        partial void ProcessAppsCreateFromManifestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsCreateFromManifestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a GitHub App from a manifest<br/>
        /// Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary `code` used to retrieve the GitHub App's `id`, `pem` (private key), and `webhook_secret`.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AllOf<global::G.Integration?, global::G.AppsCreateFromManifestResponse2?>> AppsCreateFromManifestAsync(
            string code,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAppsCreateFromManifestArguments(
                httpClient: _httpClient,
                code: ref code);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/app-manifests/{code}/conversions", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAppsCreateFromManifestRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                code: code);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAppsCreateFromManifestResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAppsCreateFromManifestResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.AllOf<global::G.Integration?, global::G.AppsCreateFromManifestResponse2?>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}