//HintName: G.AppsClient.AppsDeleteToken.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        partial void PrepareAppsDeleteTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clientId,
            global::G.AppsDeleteTokenRequest request);
        partial void PrepareAppsDeleteTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clientId,
            global::G.AppsDeleteTokenRequest request);
        partial void ProcessAppsDeleteTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete an app token<br/>
        /// OAuth  or GitHub application owners can revoke a single token for an OAuth application or a GitHub application with an OAuth authorization.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AppsDeleteTokenAsync(
            string clientId,
            global::G.AppsDeleteTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAppsDeleteTokenArguments(
                httpClient: HttpClient,
                clientId: ref clientId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/applications/{clientId}/token",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAppsDeleteTokenRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                clientId: clientId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAppsDeleteTokenResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Delete an app token<br/>
        /// OAuth  or GitHub application owners can revoke a single token for an OAuth application or a GitHub application with an OAuth authorization.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken">
        /// The OAuth access token used to authenticate to the GitHub API.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AppsDeleteTokenAsync(
            string clientId,
            string accessToken,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AppsDeleteTokenRequest
            {
                AccessToken = accessToken,
            };

            await AppsDeleteTokenAsync(
                clientId: clientId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}