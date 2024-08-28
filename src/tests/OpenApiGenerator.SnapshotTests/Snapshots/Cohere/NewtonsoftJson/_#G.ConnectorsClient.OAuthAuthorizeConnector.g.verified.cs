//HintName: G.ConnectorsClient.OAuthAuthorizeConnector.g.cs

#nullable enable

namespace G
{
    public partial class ConnectorsClient
    {
        partial void PrepareOAuthAuthorizeConnectorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? afterTokenRedirect,
            ref string? xClientName);
        partial void PrepareOAuthAuthorizeConnectorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? afterTokenRedirect,
            string? xClientName);
        partial void ProcessOAuthAuthorizeConnectorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOAuthAuthorizeConnectorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Authorize with oAuth<br/>
        /// Authorize the connector with the given ID for the connector oauth app.  See ['Connector Authentication'](https://docs.cohere.com/docs/connector-authentication) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="afterTokenRedirect"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OAuthAuthorizeResponse> OAuthAuthorizeConnectorAsync(
            string id,
            string? afterTokenRedirect,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOAuthAuthorizeConnectorArguments(
                httpClient: _httpClient,
                id: ref id,
                afterTokenRedirect: ref afterTokenRedirect,
                xClientName: ref xClientName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/connectors/{id}/oauth/authorize?after_token_redirect={afterTokenRedirect}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOAuthAuthorizeConnectorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                afterTokenRedirect: afterTokenRedirect,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOAuthAuthorizeConnectorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOAuthAuthorizeConnectorResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OAuthAuthorizeResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}