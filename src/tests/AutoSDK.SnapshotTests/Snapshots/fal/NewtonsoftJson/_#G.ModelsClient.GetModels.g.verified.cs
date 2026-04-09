//HintName: G.ModelsClient.GetModels.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetModelsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetModelsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetModelsSecurityRequirement0,
            };
        partial void PrepareGetModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref string? cursor,
            ref global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId,
            ref string? q,
            ref string? category,
            ref global::G.GetModelsStatus? status,
            ref global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand);
        partial void PrepareGetModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            string? cursor,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId,
            string? q,
            string? category,
            global::G.GetModelsStatus? status,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand);
        partial void ProcessGetModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Model search<br/>
        /// Unified endpoint for discovering model endpoints. Supports three usage modes:<br/>
        /// **1. List Mode** (no parameters):<br/>
        /// Paginated list of all available model endpoints with minimal metadata.<br/>
        /// **2. Find Mode** (`endpoint_id` parameter):<br/>
        /// Retrieve specific model endpoint(s) by ID. Supports single or multiple IDs.<br/>
        /// **3. Search Mode** (search parameters):<br/>
        /// Filter models by free-text query, category, or status.<br/>
        /// **Expansion:**<br/>
        /// Use `expand` to include additional data in each model object:<br/>
        /// - `openapi-3.0` — full OpenAPI 3.0 schema in the `openapi` field<br/>
        /// - `enterprise_status` — enterprise readiness status (`ready` or `pending`) in the `enterprise_status` field<br/>
        /// **Examples of `endpoint_id` values:**<br/>
        /// - `fal-ai/flux/dev`<br/>
        /// - `fal-ai/wan/v2.2-a14b/text-to-video`<br/>
        /// - `fal-ai/minimax/video-01/image-to-video`<br/>
        /// - `fal-ai/hunyuan3d-v21`<br/>
        /// See [fal.ai Model APIs](https://docs.fal.ai/model-apis) for more details.<br/>
        /// **Authentication:** Optional. Providing an API key grants higher rate limits.<br/>
        /// **Common Use Cases:**<br/>
        /// - Browse available models for integration<br/>
        /// - Retrieve metadata for specific endpoints<br/>
        /// - Search for models by category or keywords<br/>
        /// - Get OpenAPI schemas for code generation<br/>
        /// - Build model selection interfaces<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="endpointId">
        /// Endpoint ID(s) to retrieve (e.g., 'fal-ai/flux/dev'). Can be a single value or multiple values (1-50 models). When combined with search params, narrows results to these IDs. Use array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev, fal-ai/flux-pro]
        /// </param>
        /// <param name="q">
        /// Free-text search query to filter models by name, description, or category<br/>
        /// Example: text to image
        /// </param>
        /// <param name="category">
        /// Filter by category (e.g., 'text-to-image', 'image-to-video', 'training')<br/>
        /// Example: text-to-image
        /// </param>
        /// <param name="status">
        /// Filter models by status - omit to include all statuses<br/>
        /// Example: active
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Supported values: 'openapi-3.0' (includes full OpenAPI 3.0 schema in 'openapi' field), 'enterprise_status' (includes enterprise readiness status)<br/>
        /// Example: [openapi-3.0, enterprise_status]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetModelsResponse> GetModelsAsync(
            int? limit = default,
            string? cursor = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            string? q = default,
            string? category = default,
            global::G.GetModelsStatus? status = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetModelsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                cursor: ref cursor,
                endpointId: ref endpointId,
                q: ref q,
                category: ref category,
                status: ref status,
                expand: ref expand);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetModelsSecurityRequirements,
                operationName: "GetModelsAsync");

            var statusValue = status switch
            {
                global::G.GetModelsStatus.Active => "active",
                global::G.GetModelsStatus.Deprecated => "deprecated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/models",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("endpoint_id", endpointId?.ToString())
                .AddOptionalParameter("q", q)
                .AddOptionalParameter("category", category)
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("expand", expand?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetModelsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                limit: limit,
                cursor: cursor,
                endpointId: endpointId,
                q: q,
                category: category,
                status: status,
                expand: expand);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetModelsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.GetModelsResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.GetModelsResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.GetModelsResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.GetModelsResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.GetModelsResponse3? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.GetModelsResponse3.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.GetModelsResponse3.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.GetModelsResponse3>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.GetModelsResponse4? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.GetModelsResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.GetModelsResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.GetModelsResponse4>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.GetModelsResponse5? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.GetModelsResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.GetModelsResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.GetModelsResponse5>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessGetModelsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetModelsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetModelsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
    }
}