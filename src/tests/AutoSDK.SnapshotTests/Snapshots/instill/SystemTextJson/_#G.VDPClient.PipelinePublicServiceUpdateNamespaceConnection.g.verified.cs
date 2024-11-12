//HintName: G.VDPClient.PipelinePublicServiceUpdateNamespaceConnection.g.cs

#nullable enable

namespace G
{
    public partial class VDPClient
    {
        partial void PreparePipelinePublicServiceUpdateNamespaceConnectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string connectionId,
            global::G.Connection request);
        partial void PreparePipelinePublicServiceUpdateNamespaceConnectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string connectionId,
            global::G.Connection request);
        partial void ProcessPipelinePublicServiceUpdateNamespaceConnectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceUpdateNamespaceConnectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a connection<br/>
        /// Updates a connection with the supplied connection fields.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateNamespaceConnectionResponse> PipelinePublicServiceUpdateNamespaceConnectionAsync(
            string namespaceId,
            string connectionId,
            global::G.Connection request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceUpdateNamespaceConnectionArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                connectionId: ref connectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/connections/{connectionId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePipelinePublicServiceUpdateNamespaceConnectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                connectionId: connectionId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceUpdateNamespaceConnectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::G.RpcStatus? __value_default = null;
                if (ReadResponseAsString)
                {
                    __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = global::G.RpcStatus.FromJson(__content_default, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_default = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = await global::G.RpcStatus.FromJsonStreamAsync(__contentStream_default, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.RpcStatus>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPipelinePublicServiceUpdateNamespaceConnectionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                return
                    global::G.UpdateNamespaceConnectionResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.UpdateNamespaceConnectionResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update a connection<br/>
        /// Updates a connection with the supplied connection fields.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="connectionId"></param>
        /// <param name="id">
        /// ID.
        /// </param>
        /// <param name="integrationId">
        /// Integration ID. It determines for which type of components can reference<br/>
        /// this connection.
        /// </param>
        /// <param name="method">
        /// Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </param>
        /// <param name="setup">
        /// Connection details. This field is required on creation, optional on view.<br/>
        /// When viewing the connection details, the setup values will be redacted.
        /// </param>
        /// <param name="scopes">
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf. This is typically passed on creation<br/>
        /// when the setup has been generated through an OAuth flow with a limited set<br/>
        /// of scopes.
        /// </param>
        /// <param name="identity">
        /// When the connection method is METHOD_OAUTH, this field will hold the<br/>
        /// identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </param>
        /// <param name="oAuthAccessDetails">
        /// When the connection method is METHOD_OAUTH, the access token might come<br/>
        /// with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateNamespaceConnectionResponse> PipelinePublicServiceUpdateNamespaceConnectionAsync(
            string namespaceId,
            string connectionId,
            string id,
            string integrationId,
            global::G.Method method,
            object setup,
            global::System.Collections.Generic.IList<string>? scopes = default,
            string? identity = default,
            object? oAuthAccessDetails = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Connection
            {
                Id = id,
                IntegrationId = integrationId,
                Method = method,
                Setup = setup,
                Scopes = scopes,
                Identity = identity,
                OAuthAccessDetails = oAuthAccessDetails,
            };

            return await PipelinePublicServiceUpdateNamespaceConnectionAsync(
                namespaceId: namespaceId,
                connectionId: connectionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}