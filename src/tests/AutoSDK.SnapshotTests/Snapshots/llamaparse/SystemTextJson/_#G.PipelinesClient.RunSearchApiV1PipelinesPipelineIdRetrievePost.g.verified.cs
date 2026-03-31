//HintName: G.PipelinesClient.RunSearchApiV1PipelinesPipelineIdRetrievePost.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareRunSearchApiV1PipelinesPipelineIdRetrievePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid pipelineId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::G.RetrievalParams request);
        partial void PrepareRunSearchApiV1PipelinesPipelineIdRetrievePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid pipelineId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::G.RetrievalParams request);
        partial void ProcessRunSearchApiV1PipelinesPipelineIdRetrievePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRunSearchApiV1PipelinesPipelineIdRetrievePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Run Search<br/>
        /// Run a retrieval query against a managed pipeline.<br/>
        /// Searches the pipeline's vector store using the provided query<br/>
        /// and retrieval parameters. Supports dense, sparse, and hybrid<br/>
        /// search modes with configurable top-k and reranking.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RetrieveResults> RunSearchApiV1PipelinesPipelineIdRetrievePostAsync(
            global::System.Guid pipelineId,

            global::G.RetrievalParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRunSearchApiV1PipelinesPipelineIdRetrievePostArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/pipelines/{pipelineId}/retrieve",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
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
            PrepareRunSearchApiV1PipelinesPipelineIdRetrievePostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRunSearchApiV1PipelinesPipelineIdRetrievePostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
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
                ProcessRunSearchApiV1PipelinesPipelineIdRetrievePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.RetrieveResults.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.RetrieveResults.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Run Search<br/>
        /// Run a retrieval query against a managed pipeline.<br/>
        /// Searches the pipeline's vector store using the provided query<br/>
        /// and retrieval parameters. Supports dense, sparse, and hybrid<br/>
        /// search modes with configurable top-k and reranking.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="denseSimilarityTopK">
        /// Number of nodes for dense retrieval.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="denseSimilarityCutoff">
        /// Minimum similarity score wrt query for retrieval<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="sparseSimilarityTopK">
        /// Number of nodes for sparse retrieval.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="enableReranking">
        /// Enable reranking for retrieval
        /// </param>
        /// <param name="rerankTopN">
        /// Number of reranked nodes for returning.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="alpha">
        /// Alpha value for hybrid retrieval to determine the weights between dense and sparse retrieval. 0 is sparse retrieval and 1 is dense retrieval.
        /// </param>
        /// <param name="searchFilters">
        /// Search filters for retrieval.
        /// </param>
        /// <param name="searchFiltersInferenceSchema">
        /// JSON Schema that will be used to infer search_filters. Omit or leave as null to skip inference.
        /// </param>
        /// <param name="filesTopK">
        /// Number of files to retrieve (only for retrieval mode files_via_metadata and files_via_content).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="retrievalMode">
        /// The retrieval mode for the query.<br/>
        /// Default Value: chunks
        /// </param>
        /// <param name="retrievePageScreenshotNodes">
        /// Whether to retrieve page screenshot nodes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="retrievePageFigureNodes">
        /// Whether to retrieve page figure nodes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="query">
        /// The query to retrieve against.
        /// </param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RetrieveResults> RunSearchApiV1PipelinesPipelineIdRetrievePostAsync(
            global::System.Guid pipelineId,
            string query,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? denseSimilarityTopK = default,
            double? denseSimilarityCutoff = default,
            int? sparseSimilarityTopK = default,
            bool? enableReranking = default,
            int? rerankTopN = default,
            double? alpha = default,
            global::G.MetadataFilters? searchFilters = default,
            object? searchFiltersInferenceSchema = default,
            int? filesTopK = default,
            global::G.RetrievalMode? retrievalMode = default,
            bool? retrievePageScreenshotNodes = default,
            bool? retrievePageFigureNodes = default,
            string? className = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.RetrievalParams
            {
                DenseSimilarityTopK = denseSimilarityTopK,
                DenseSimilarityCutoff = denseSimilarityCutoff,
                SparseSimilarityTopK = sparseSimilarityTopK,
                EnableReranking = enableReranking,
                RerankTopN = rerankTopN,
                Alpha = alpha,
                SearchFilters = searchFilters,
                SearchFiltersInferenceSchema = searchFiltersInferenceSchema,
                FilesTopK = filesTopK,
                RetrievalMode = retrievalMode,
                RetrievePageScreenshotNodes = retrievePageScreenshotNodes,
                RetrievePageFigureNodes = retrievePageFigureNodes,
                Query = query,
                ClassName = className,
            };

            return await RunSearchApiV1PipelinesPipelineIdRetrievePostAsync(
                pipelineId: pipelineId,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}