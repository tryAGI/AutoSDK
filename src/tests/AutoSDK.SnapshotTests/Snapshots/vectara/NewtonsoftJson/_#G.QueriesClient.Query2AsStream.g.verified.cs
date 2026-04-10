//HintName: G.QueriesClient.Query2AsStream.g.cs

#nullable enable

namespace G
{
    public partial class QueriesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_Query2AsStreamSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_Query2AsStreamSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "OAuth2",
                        SchemeId = "OAuth2",
                        Location = "Header",
                        Name = "",
                        FriendlyName = "OAuth2",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_Query2AsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_Query2AsStreamSecurityRequirement0,
                s_Query2AsStreamSecurityRequirement1,
            };
        partial void PrepareQuery2AsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.QueryRequest request);
        partial void PrepareQuery2AsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.QueryRequest request);
        partial void ProcessQuery2AsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multipurpose query to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG). Similar to the [advanced corpora search](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is created in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus), and the corpus key is part of that process. When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests.<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results.<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt-in by setting the `generation` property. By excluding the property or by setting it to null, the response will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify Vectara's RAG-focused LLM (Mockingbird) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.QueryStreamedResponse> Query2AsStreamAsync(

            global::G.QueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQuery2AsStreamArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Query2AsStreamSecurityRequirements,
                operationName: "Query2AsStreamAsync");

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/v2/query",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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

                if (requestTimeout != default)
                {
                    __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
                }
                if (requestTimeoutMillis != default)
                {
                    __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
                }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareQuery2AsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    requestTimeout: requestTimeout,
                    requestTimeoutMillis: requestTimeoutMillis,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Query2AsStream",
                                methodName: "Query2AsStreamAsync",
                                pathTemplate: "\"/v2/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await global::G.Api.AutoSDKOAuth2Helpers.SendAsync(
                httpClient: HttpClient,
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Query2AsStream",
                                methodName: "Query2AsStreamAsync",
                                pathTemplate: "\"/v2/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Query2AsStream",
                                methodName: "Query2AsStreamAsync",
                                pathTemplate: "\"/v2/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessQuery2AsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Query2AsStream",
                                methodName: "Query2AsStreamAsync",
                                pathTemplate: "\"/v2/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Query2AsStream",
                                methodName: "Query2AsStreamAsync",
                                pathTemplate: "\"/v2/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::G.QueryStreamedResponse.FromJson(__content, JsonSerializerOptions) ??
                                                       throw new global::G.ApiException(
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           statusCode: __response.StatusCode)
                                                       {
                                                           ResponseBody = __content,
                                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value),
                                                       };

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multipurpose query to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG). Similar to the [advanced corpora search](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is created in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus), and the corpus key is part of that process. When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests.<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results.<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt-in by setting the `generation` property. By excluding the property or by setting it to null, the response will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify Vectara's RAG-focused LLM (Mockingbird) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save the query to query history.
        /// </param>
        /// <param name="intelligentQueryRewriting">
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to extract metadata filter and rewrite the query to improve search results. Read [here](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.QueryStreamedResponse> Query2AsStreamAsync(
            string query,
            global::G.SearchCorporaParameters search,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.GenerationParameters? generation = default,
            bool? streamResponse = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.QueryRequest
            {
                Query = query,
                Search = search,
                Generation = generation,
                StreamResponse = streamResponse,
                SaveHistory = saveHistory,
                IntelligentQueryRewriting = intelligentQueryRewriting,
            };

            var __enumerable = Query2AsStreamAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}