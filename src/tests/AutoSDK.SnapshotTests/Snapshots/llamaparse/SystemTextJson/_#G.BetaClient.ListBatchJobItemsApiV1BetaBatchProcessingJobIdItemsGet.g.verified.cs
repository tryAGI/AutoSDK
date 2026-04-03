//HintName: G.BetaClient.ListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGet.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {
        partial void PrepareListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string jobId,
            global::G.BatchFileStatus? status,
            ref int? limit,
            ref int? offset,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session);
        partial void PrepareListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string jobId,
            global::G.BatchFileStatus? status,
            int? limit,
            int? offset,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session);
        partial void ProcessListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Batch Job Items<br/>
        /// List items in a batch job with optional status filtering.<br/>
        /// Useful for finding failed items, viewing completed items,<br/>
        /// or debugging processing issues.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status">
        /// Filter items by status
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Number of items to skip<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchItemListResponse> ListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetAsync(
            string jobId,
            global::G.BatchFileStatus? status = default,
            int? limit = default,
            int? offset = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetArguments(
                httpClient: HttpClient,
                jobId: ref jobId,
                status: status,
                limit: ref limit,
                offset: ref offset,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/beta/batch-processing/{jobId}/items",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("status", status?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                jobId: jobId,
                status: status,
                limit: limit,
                offset: offset,
                projectId: projectId,
                organizationId: organizationId,
                session: session);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetResponse(
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
                ProcessListBatchJobItemsApiV1BetaBatchProcessingJobIdItemsGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.BatchItemListResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.BatchItemListResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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