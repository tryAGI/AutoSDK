//HintName: G.ConnectorsClient.UpdateConnector.g.cs

#nullable enable

namespace G
{
    public partial class ConnectorsClient
    {
        partial void PrepareUpdateConnectorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? xClientName,
            global::G.UpdateConnectorRequest request);
        partial void PrepareUpdateConnectorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? xClientName,
            global::G.UpdateConnectorRequest request);
        partial void ProcessUpdateConnectorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateConnectorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a Connector<br/>
        /// Update a connector by ID. Omitted fields will not be updated. See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConnectorResponse> UpdateConnectorAsync(
            string id,
            global::G.UpdateConnectorRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateConnectorArguments(
                httpClient: _httpClient,
                id: ref id,
                xClientName: ref xClientName,
                request: request);

            if (xClientName != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: $"/v1/connectors/{id}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateConnectorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateConnectorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateConnectorResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateConnectorResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a Connector<br/>
        /// Update a connector by ID. Omitted fields will not be updated. See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="continueOnFailure">
        /// Default Value: false
        /// </param>
        /// <param name="serviceAuth"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConnectorResponse> UpdateConnectorAsync(
            string id,
            string? xClientName = default,
            string? name = default,
            string? url = default,
            global::System.Collections.Generic.IList<string>? excludes = default,
            global::G.CreateConnectorOAuth? oauth = default,
            bool? active = true,
            bool? continueOnFailure = false,
            global::G.CreateConnectorServiceAuth? serviceAuth = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateConnectorRequest
            {
                Name = name,
                Url = url,
                Excludes = excludes,
                Oauth = oauth,
                Active = active,
                ContinueOnFailure = continueOnFailure,
                ServiceAuth = serviceAuth,
            };

            return await UpdateConnectorAsync(
                id: id,
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}