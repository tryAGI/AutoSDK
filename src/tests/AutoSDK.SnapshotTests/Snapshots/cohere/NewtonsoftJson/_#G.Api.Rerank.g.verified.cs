//HintName: G.Api.Rerank.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareRerankArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.RerankRequest request);
        partial void PrepareRerankRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.RerankRequest request);
        partial void ProcessRerankResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRerankResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Rerank V1 API<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            global::G.RerankRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRerankArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/rerank",
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

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
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
            PrepareRerankRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRerankResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.RerankResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.RerankResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = await global::G.RerankResponse2.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse2>(
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
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.RerankResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.RerankResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = await global::G.RerankResponse3.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse3>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.RerankResponse4? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.RerankResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = await global::G.RerankResponse4.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse4>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a resource is not found. This could be because:   - The endpoint does not exist   - The resource does not exist eg model id, dataset id 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.RerankResponse5? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.RerankResponse5.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = await global::G.RerankResponse5.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse5>(
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
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.RerankResponse6? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.RerankResponse6.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::G.RerankResponse6.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse6>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.RerankResponse7? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.RerankResponse7.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = await global::G.RerankResponse7.FromJsonStreamAsync(__contentStream_429, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse7>(
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
            // This error is returned when a request or response contains a deny-listed token. 
            if ((int)__response.StatusCode == 498)
            {
                string? __content_498 = null;
                global::System.Exception? __exception_498 = null;
                global::G.RerankResponse8? __value_498 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_498 = global::G.RerankResponse8.FromJson(__content_498, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_498 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_498 = await global::G.RerankResponse8.FromJsonStreamAsync(__contentStream_498, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_498 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse8>(
                    message: __content_498 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_498,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_498,
                    ResponseObject = __value_498,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request is cancelled by the user. 
            if ((int)__response.StatusCode == 499)
            {
                string? __content_499 = null;
                global::System.Exception? __exception_499 = null;
                global::G.RerankResponse9? __value_499 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_499 = global::G.RerankResponse9.FromJson(__content_499, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_499 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_499 = await global::G.RerankResponse9.FromJsonStreamAsync(__contentStream_499, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_499 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse9>(
                    message: __content_499 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_499,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_499,
                    ResponseObject = __value_499,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when an uncategorised internal server error occurs. 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.RerankResponse10? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.RerankResponse10.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = await global::G.RerankResponse10.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse10>(
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
            // This error is returned when the requested feature is not implemented. 
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::System.Exception? __exception_501 = null;
                global::G.RerankResponse11? __value_501 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_501 = global::G.RerankResponse11.FromJson(__content_501, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_501 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_501 = await global::G.RerankResponse11.FromJsonStreamAsync(__contentStream_501, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_501 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse11>(
                    message: __content_501 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_501,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the service is unavailable. This could be due to:   - Too many users trying to access the service at the same time 
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                global::G.RerankResponse12? __value_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = global::G.RerankResponse12.FromJson(__content_503, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = await global::G.RerankResponse12.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse12>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request to the server times out. This could be due to:   - An internal services taking too long to respond 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::System.Exception? __exception_504 = null;
                global::G.RerankResponse13? __value_504 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_504 = global::G.RerankResponse13.FromJson(__content_504, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_504 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_504 = await global::G.RerankResponse13.FromJsonStreamAsync(__contentStream_504, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_504 = __ex;
                }

                throw new global::G.ApiException<global::G.RerankResponse13>(
                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_504,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
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
                ProcessRerankResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.RerankResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.RerankResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Rerank V1 API<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="documents">
        /// A list of document objects or strings to rerank.<br/>
        /// If a document is provided the text fields is required and all other fields will be preserved in the response.<br/>
        /// The total max chunks (length of documents * max_chunks_per_doc) must be less than 10000.<br/>
        /// We recommend a maximum of 1,000 documents for optimal endpoint performance.
        /// </param>
        /// <param name="maxChunksPerDoc">
        /// The maximum number of chunks to produce internally from a document<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="model">
        /// The identifier of the model to use, eg `rerank-v3.5`.
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="rankFields">
        /// If a JSON object is provided, you can specify which keys you would like to have considered for reranking. The model will rerank based on order of the fields passed in (i.e. rank_fields=['title','author','text'] will rerank using the values in title, author, text  sequentially. If the length of title, author, and text exceeds the context length of the model, the chunking will not re-consider earlier fields). If not provided, the model will use the default text field for ranking.
        /// </param>
        /// <param name="returnDocuments">
        /// - If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.<br/>
        /// - If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topN">
        /// The number of most relevant documents or indices to return, defaults to the length of the documents
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> documents,
            string query,
            string? xClientName = default,
            int? maxChunksPerDoc = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            bool? returnDocuments = default,
            int? topN = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RerankRequest
            {
                Documents = documents,
                MaxChunksPerDoc = maxChunksPerDoc,
                Model = model,
                Query = query,
                RankFields = rankFields,
                ReturnDocuments = returnDocuments,
                TopN = topN,
            };

            return await RerankAsync(
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}