//HintName: G.BetaClient.CreateBatchJobApiV1BetaBatchProcessingPost.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {
        partial void PrepareCreateBatchJobApiV1BetaBatchProcessingPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? temporalNamespace,
            ref string? session,
            global::G.BatchJobCreateRequest request);
        partial void PrepareCreateBatchJobApiV1BetaBatchProcessingPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? temporalNamespace,
            string? session,
            global::G.BatchJobCreateRequest request);
        partial void ProcessCreateBatchJobApiV1BetaBatchProcessingPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateBatchJobApiV1BetaBatchProcessingPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Batch Job<br/>
        /// Create a batch processing job.<br/>
        /// Processes files from a directory or a specific list of item IDs.<br/>
        /// Supports batch parsing and classification operations.<br/>
        /// Provide either `directory_id` to process all files in a directory,<br/>
        /// or `item_ids` for specific items. The job runs asynchronously —<br/>
        /// poll `GET /batch/{job_id}` for progress.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchJobResponse> CreateBatchJobApiV1BetaBatchProcessingPostAsync(

            global::G.BatchJobCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateBatchJobApiV1BetaBatchProcessingPostArguments(
                httpClient: HttpClient,
                projectId: projectId,
                organizationId: organizationId,
                temporalNamespace: ref temporalNamespace,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/beta/batch-processing",
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

            if (temporalNamespace != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("temporal-namespace", temporalNamespace.ToString());
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
            PrepareCreateBatchJobApiV1BetaBatchProcessingPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                organizationId: organizationId,
                temporalNamespace: temporalNamespace,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateBatchJobApiV1BetaBatchProcessingPostResponse(
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
                ProcessCreateBatchJobApiV1BetaBatchProcessingPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.BatchJobResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.BatchJobResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Batch Job<br/>
        /// Create a batch processing job.<br/>
        /// Processes files from a directory or a specific list of item IDs.<br/>
        /// Supports batch parsing and classification operations.<br/>
        /// Provide either `directory_id` to process all files in a directory,<br/>
        /// or `item_ids` for specific items. The job runs asynchronously —<br/>
        /// poll `GET /batch/{job_id}` for progress.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="directoryId">
        /// ID of the directory containing files to process
        /// </param>
        /// <param name="itemIds">
        /// List of specific item IDs to process. Either this or directory_id must be provided.
        /// </param>
        /// <param name="jobConfig">
        /// Job configuration — either a parse or classify config
        /// </param>
        /// <param name="pageSize">
        /// Number of files to process per batch when using directory mode<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="continueAsNewThreshold">
        /// Maximum files to process per execution cycle in directory mode. Defaults to page_size.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchJobResponse> CreateBatchJobApiV1BetaBatchProcessingPostAsync(
            global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> jobConfig,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            string? directoryId = default,
            global::System.Collections.Generic.IList<string>? itemIds = default,
            int? pageSize = default,
            int? continueAsNewThreshold = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BatchJobCreateRequest
            {
                DirectoryId = directoryId,
                ItemIds = itemIds,
                JobConfig = jobConfig,
                PageSize = pageSize,
                ContinueAsNewThreshold = continueAsNewThreshold,
            };

            return await CreateBatchJobApiV1BetaBatchProcessingPostAsync(
                projectId: projectId,
                organizationId: organizationId,
                temporalNamespace: temporalNamespace,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}