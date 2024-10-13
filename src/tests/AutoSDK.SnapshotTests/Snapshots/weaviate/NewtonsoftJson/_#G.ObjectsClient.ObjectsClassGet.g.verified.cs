//HintName: G.ObjectsClient.ObjectsClassGet.g.cs

#nullable enable

namespace G
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsClassGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            ref global::System.Guid id,
            ref string? include,
            ref global::G.ObjectsClassGetConsistencyLevel? consistencyLevel,
            ref string? nodeName,
            ref string? tenant);
        partial void PrepareObjectsClassGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            global::System.Guid id,
            string? include,
            global::G.ObjectsClassGetConsistencyLevel? consistencyLevel,
            string? nodeName,
            string? tenant);
        partial void ProcessObjectsClassGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObjectsClassGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get an object.<br/>
        /// Get a data object based on its collection and UUID. Also available as Websocket bus.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="nodeName"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Object> ObjectsClassGetAsync(
            string className,
            global::System.Guid id,
            string? include = default,
            global::G.ObjectsClassGetConsistencyLevel? consistencyLevel = global::G.ObjectsClassGetConsistencyLevel.QUORUM,
            string? nodeName = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareObjectsClassGetArguments(
                httpClient: _httpClient,
                className: ref className,
                id: ref id,
                include: ref include,
                consistencyLevel: ref consistencyLevel,
                nodeName: ref nodeName,
                tenant: ref tenant);

            var consistencyLevelValue = consistencyLevel switch
            {
                global::G.ObjectsClassGetConsistencyLevel.ONE => "ONE",
                global::G.ObjectsClassGetConsistencyLevel.QUORUM => "QUORUM",
                global::G.ObjectsClassGetConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/objects/{className}/{id}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("include", include) 
                .AddOptionalParameter("consistency_level", consistencyLevelValue?.ToString()) 
                .AddOptionalParameter("node_name", nodeName) 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareObjectsClassGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                className: className,
                id: id,
                include: include,
                consistencyLevel: consistencyLevel,
                nodeName: nodeName,
                tenant: tenant);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessObjectsClassGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessObjectsClassGetResponseContent(
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
                global::G.Object.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}