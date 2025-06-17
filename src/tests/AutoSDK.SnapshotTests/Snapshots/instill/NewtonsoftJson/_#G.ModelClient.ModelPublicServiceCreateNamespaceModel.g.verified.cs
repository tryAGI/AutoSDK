//HintName: G.ModelClient.ModelPublicServiceCreateNamespaceModel.g.cs

#nullable enable

namespace G
{
    public partial class ModelClient
    {
        partial void PrepareModelPublicServiceCreateNamespaceModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            global::G.Model request);
        partial void PrepareModelPublicServiceCreateNamespaceModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            global::G.Model request);
        partial void ProcessModelPublicServiceCreateNamespaceModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelPublicServiceCreateNamespaceModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new model<br/>
        /// Creates a new model under the parenthood of a namespace. This is an<br/>
        /// asynchronous endpoint, i.e., the server will not wait for the model to be<br/>
        /// created in order to respond. Instead, it will return a response with the<br/>
        /// necessary information to access the result and status of the creation<br/>
        /// operation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateNamespaceModelResponse> ModelPublicServiceCreateNamespaceModelAsync(
            string namespaceId,
            global::G.Model request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareModelPublicServiceCreateNamespaceModelArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/models",
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
            PrepareModelPublicServiceCreateNamespaceModelRequest(
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
            ProcessModelPublicServiceCreateNamespaceModelResponse(
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
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
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
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessModelPublicServiceCreateNamespaceModelResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateNamespaceModelResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.CreateNamespaceModelResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Create a new model<br/>
        /// Creates a new model under the parenthood of a namespace. This is an<br/>
        /// asynchronous endpoint, i.e., the server will not wait for the model to be<br/>
        /// created in order to respond. Instead, it will return a response with the<br/>
        /// necessary information to access the result and status of the creation<br/>
        /// operation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="id">
        /// Model resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.
        /// </param>
        /// <param name="description">
        /// Model description.
        /// </param>
        /// <param name="modelDefinition">
        /// The model definition that has been used to import the model.
        /// </param>
        /// <param name="configuration">
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition (i.e. the `model_spec` field in the<br/>
        /// model definition).
        /// </param>
        /// <param name="task">
        /// Model task.
        /// </param>
        /// <param name="visibility">
        /// Model visibility.
        /// </param>
        /// <param name="region">
        /// Region of choice for the particular provider to host the model.
        /// </param>
        /// <param name="hardware">
        /// Hardware of choice to serve the model.
        /// </param>
        /// <param name="readme">
        /// README holds the model documentation.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the model is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Model profile image in base64 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateNamespaceModelResponse> ModelPublicServiceCreateNamespaceModelAsync(
            string namespaceId,
            string id,
            string modelDefinition,
            object configuration,
            global::G.AITask task,
            global::G.ModelVisibility visibility,
            string region,
            string hardware,
            string? description = default,
            string? readme = default,
            string? sourceUrl = default,
            string? documentationUrl = default,
            string? license = default,
            string? profileImage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Model
            {
                Id = id,
                Description = description,
                ModelDefinition = modelDefinition,
                Configuration = configuration,
                Task = task,
                Visibility = visibility,
                Region = region,
                Hardware = hardware,
                Readme = readme,
                SourceUrl = sourceUrl,
                DocumentationUrl = documentationUrl,
                License = license,
                ProfileImage = profileImage,
            };

            return await ModelPublicServiceCreateNamespaceModelAsync(
                namespaceId: namespaceId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}