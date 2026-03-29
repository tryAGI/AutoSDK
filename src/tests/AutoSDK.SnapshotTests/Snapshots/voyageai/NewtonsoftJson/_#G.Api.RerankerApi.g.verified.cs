//HintName: G.Api.RerankerApi.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareRerankerApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RerankerApiRequest request);
        partial void PrepareRerankerApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RerankerApiRequest request);
        partial void ProcessRerankerApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRerankerApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Rerankers<br/>
        /// Voyage reranker endpoint receives as input a query, a list of documents, and other arguments such as the model name, and returns a response containing the reranking results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RerankerApiResponse> RerankerApiAsync(

            global::G.RerankerApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRerankerApiArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/rerank",
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
            PrepareRerankerApiRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRerankerApiResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Client error  <p> This indicates an issue with the request format or frequency. Please see our  [Error Codes](https://docs.voyageai.com/docs/error-codes) guide. </p> 
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::G.RerankerApiResponse2? __value_4XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_4XX = global::G.RerankerApiResponse2.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_4XX = global::G.RerankerApiResponse2.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::G.ApiException<global::G.RerankerApiResponse2>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_4XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode >= 500 && (int)__response.StatusCode <= 599)
            {
                string? __content_5XX = null;
                global::System.Exception? __exception_5XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_5XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_5XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_5XX = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_5XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_5XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_5XX,
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
                ProcessRerankerApiResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.RerankerApiResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.RerankerApiResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Rerankers<br/>
        /// Voyage reranker endpoint receives as input a query, a list of documents, and other arguments such as the model name, and returns a response containing the reranking results.
        /// </summary>
        /// <param name="query">
        /// The query as a string. The query can contain a maximum of 4000 tokens for `rerank-2`, 2000 tokens for `rerank-2-lite` and `rerank-1`, and 1000 tokens for `rerank-lite-1`.
        /// </param>
        /// <param name="documents">
        /// The documents to be reranked as a list of strings. &lt;ul&gt; &lt;li&gt; The number of documents cannot exceed 1000. &lt;/li&gt; &lt;li&gt; The sum of the number of tokens in the query and the number of tokens in any single document cannot exceed 16000 for `rerank-2`; 8000 for `rerank-2-lite` and `rerank-1`; and 4000 for `rerank-lite-1`. &lt;/li&gt; &lt;li&gt; The total number of tokens, defined as "the number of query tokens × the number of documents + sum of the number of tokens in all documents", cannot exceed 600K for `rerank-2` and `rerank-2-lite`, and 300K for `rerank-1` and `rerank-lite-1`. Please see our &lt;a href="https://docs.voyageai.com/docs/faq#what-is-the-total-number-of-tokens-for-the-rerankers"&gt;FAQ&lt;/a&gt;. &lt;/li&gt; &lt;/ul&gt;
        /// </param>
        /// <param name="model">
        /// Name of the model. Recommended options: `rerank-2`, `rerank-2-lite`.
        /// </param>
        /// <param name="topK">
        /// The number of most relevant documents to return. If not specified, the reranking results of all documents will be returned.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return the documents in the response. Defaults to `false`. &lt;ul&gt; &lt;li&gt; If `false`, the API will return a list of {"index", "relevance_score"} where "index" refers to the index of a document within the input list. &lt;/li&gt; &lt;li&gt; If `true`, the API will return a list of {"index", "document", "relevance_score"} where "document" is the corresponding document from the input list. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: false
        /// </param>
        /// <param name="truncation">
        /// Whether to truncate the input to satisfy the "context length limit" on the query and the documents. Defaults to `true`. &lt;ul&gt; &lt;li&gt; If `true`,  the query and documents will be truncated to fit within the context length limit, before processed by the reranker model. &lt;/li&gt; &lt;li&gt; If `false`, an error will be raised when the query exceeds 4000 tokens for `rerank-2`; 2000 tokens `rerank-2-lite` and `rerank-1`; and 1000 tokens for `rerank-lite-1`, or the sum of the number of tokens in the query and the number of tokens in any single document exceeds 16000 for `rerank-2`; 8000 for `rerank-2-lite` and `rerank-1`; and 4000 for `rerank-lite-1`. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RerankerApiResponse> RerankerApiAsync(
            string query,
            global::System.Collections.Generic.IList<string> documents,
            string model,
            int? topK = default,
            bool? returnDocuments = default,
            bool? truncation = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RerankerApiRequest
            {
                Query = query,
                Documents = documents,
                Model = model,
                TopK = topK,
                ReturnDocuments = returnDocuments,
                Truncation = truncation,
            };

            return await RerankerApiAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}