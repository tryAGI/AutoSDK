//HintName: G.SearchClient.SearchDocuments.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        partial void PrepareSearchDocumentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? n,
            ref string? nextToken,
            ref int? verbosity,
            global::G.SearchDocumentsRequest request);
        partial void PrepareSearchDocumentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? n,
            string? nextToken,
            int? verbosity,
            global::G.SearchDocumentsRequest request);
        partial void ProcessSearchDocumentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchDocumentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// search.documents<br/>
        /// Search documents on GroundX for the most relevant information to a given query by documentId(s).<br/>
        /// The result of this query is typically used in one of two ways; result['search']['text'] can be used to provide context to a language model, facilitating RAG, or result['search']['results'] can be used to observe chunks of text which are relevant to the query, facilitating citation.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="n">
        /// Default Value: 20
        /// </param>
        /// <param name="nextToken">
        /// Example: eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9
        /// </param>
        /// <param name="verbosity"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchDocumentsAsync(

            global::G.SearchDocumentsRequest request,
            int? n = default,
            string? nextToken = default,
            int? verbosity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSearchDocumentsArguments(
                httpClient: HttpClient,
                n: ref n,
                nextToken: ref nextToken,
                verbosity: ref verbosity,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/search/documents",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("n", n?.ToString())
                .AddOptionalParameter("nextToken", nextToken)
                .AddOptionalParameter("verbosity", verbosity?.ToString()) 
                ; 
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
            PrepareSearchDocumentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                n: n,
                nextToken: nextToken,
                verbosity: verbosity,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchDocumentsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
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
                ProcessSearchDocumentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// search.documents<br/>
        /// Search documents on GroundX for the most relevant information to a given query by documentId(s).<br/>
        /// The result of this query is typically used in one of two ways; result['search']['text'] can be used to provide context to a language model, facilitating RAG, or result['search']['results'] can be used to observe chunks of text which are relevant to the query, facilitating citation.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="n">
        /// Default Value: 20
        /// </param>
        /// <param name="nextToken">
        /// Example: eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9
        /// </param>
        /// <param name="verbosity"></param>
        /// <param name="query">
        /// The search query to be used to find relevant documentation.<br/>
        /// Default Value: my search query<br/>
        /// Example: my search query
        /// </param>
        /// <param name="documentIds">
        /// An array of unique documentIds to be searched.<br/>
        /// Example: [docUUID1, docUUID2]
        /// </param>
        /// <param name="relevance">
        /// The minimum search relevance score required to include the result. By default, this is 10.0.<br/>
        /// Default Value: 10.0<br/>
        /// Example: 10.0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchDocumentsAsync(
            global::System.Collections.Generic.IList<string> documentIds,
            int? n = default,
            string? nextToken = default,
            int? verbosity = default,
            string query = "my search query",
            float? relevance = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SearchDocumentsRequest
            {
                Query = query,
                DocumentIds = documentIds,
                Relevance = relevance,
            };

            return await SearchDocumentsAsync(
                n: n,
                nextToken: nextToken,
                verbosity: verbosity,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}