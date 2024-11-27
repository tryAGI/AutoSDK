//HintName: G.VDPClient.PipelinePublicServiceCreateNamespaceConnection.g.cs

#nullable enable

namespace G
{
    public partial class VDPClient
    {
        partial void PreparePipelinePublicServiceCreateNamespaceConnectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            global::G.Connection request);
        partial void PreparePipelinePublicServiceCreateNamespaceConnectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            global::G.Connection request);
        partial void ProcessPipelinePublicServiceCreateNamespaceConnectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceCreateNamespaceConnectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a connection<br/>
        /// Creates a connection under the ownership of a namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateNamespaceConnectionResponse> PipelinePublicServiceCreateNamespaceConnectionAsync(
            string namespaceId,
            global::G.Connection request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceCreateNamespaceConnectionArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/connections",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PreparePipelinePublicServiceCreateNamespaceConnectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceCreateNamespaceConnectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returned when the client credentials are not valid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_401)));
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
            // An unexpected error response.
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
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPipelinePublicServiceCreateNamespaceConnectionResponseContent(
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
                    global::G.CreateNamespaceConnectionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.CreateNamespaceConnectionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create a connection<br/>
        /// Creates a connection under the ownership of a namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
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
        public async global::System.Threading.Tasks.Task<global::G.CreateNamespaceConnectionResponse> PipelinePublicServiceCreateNamespaceConnectionAsync(
            string namespaceId,
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

            return await PipelinePublicServiceCreateNamespaceConnectionAsync(
                namespaceId: namespaceId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}