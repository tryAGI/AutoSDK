//HintName: G.V2Client.ListExtractJobsApiV2ExtractGet.g.cs

#nullable enable

namespace G
{
    public partial class V2Client
    {
        partial void PrepareListExtractJobsApiV2ExtractGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? configurationId,
            ref string? documentInputType,
            ref string? documentInputValue,
            global::G.ListExtractJobsApiV2ExtractGetStatus2? status,
            int? pageSize,
            ref string? pageToken,
            global::System.DateTime? createdAtOnOrAfter,
            global::System.DateTime? createdAtOnOrBefore,
            global::System.Collections.Generic.IList<string>? jobIds,
            global::System.Collections.Generic.IList<string>? expand,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session);
        partial void PrepareListExtractJobsApiV2ExtractGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? configurationId,
            string? documentInputType,
            string? documentInputValue,
            global::G.ListExtractJobsApiV2ExtractGetStatus2? status,
            int? pageSize,
            string? pageToken,
            global::System.DateTime? createdAtOnOrAfter,
            global::System.DateTime? createdAtOnOrBefore,
            global::System.Collections.Generic.IList<string>? jobIds,
            global::System.Collections.Generic.IList<string>? expand,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session);
        partial void ProcessListExtractJobsApiV2ExtractGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListExtractJobsApiV2ExtractGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Extract Jobs<br/>
        /// List extraction jobs with optional filtering and pagination.<br/>
        /// Filter by `configuration_id`, `status`, `document_input_value`,<br/>
        /// or creation date range. Results are returned newest-first.<br/>
        /// Use `expand=configuration` to include the full configuration used,<br/>
        /// and `expand=extract_metadata` for per-field metadata.
        /// </summary>
        /// <param name="configurationId">
        /// Filter by configuration ID
        /// </param>
        /// <param name="documentInputType">
        /// Filter by document input type (file_id or parse_job_id)
        /// </param>
        /// <param name="documentInputValue">
        /// Filter by document input value
        /// </param>
        /// <param name="status">
        /// Filter by status
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="createdAtOnOrAfter">
        /// Include jobs created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include jobs created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="expand">
        /// Additional fields to include: configuration, extract_metadata
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExtractV2JobQueryResponse> ListExtractJobsApiV2ExtractGetAsync(
            string? configurationId = default,
            string? documentInputType = default,
            string? documentInputValue = default,
            global::G.ListExtractJobsApiV2ExtractGetStatus2? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListExtractJobsApiV2ExtractGetArguments(
                httpClient: HttpClient,
                configurationId: ref configurationId,
                documentInputType: ref documentInputType,
                documentInputValue: ref documentInputValue,
                status: status,
                pageSize: pageSize,
                pageToken: ref pageToken,
                createdAtOnOrAfter: createdAtOnOrAfter,
                createdAtOnOrBefore: createdAtOnOrBefore,
                jobIds: jobIds,
                expand: expand,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v2/extract",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("configuration_id", configurationId)
                .AddOptionalParameter("document_input_type", documentInputType)
                .AddOptionalParameter("document_input_value", documentInputValue)
                .AddOptionalParameter("status", status?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("page_token", pageToken)
                .AddOptionalParameter("created_at_on_or_after", createdAtOnOrAfter?.ToString())
                .AddOptionalParameter("created_at_on_or_before", createdAtOnOrBefore?.ToString())
                .AddOptionalParameter("job_ids", jobIds?.ToString())
                .AddOptionalParameter("expand", expand, delimiter: ",", explode: true)
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
            PrepareListExtractJobsApiV2ExtractGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                configurationId: configurationId,
                documentInputType: documentInputType,
                documentInputValue: documentInputValue,
                status: status,
                pageSize: pageSize,
                pageToken: pageToken,
                createdAtOnOrAfter: createdAtOnOrAfter,
                createdAtOnOrBefore: createdAtOnOrBefore,
                jobIds: jobIds,
                expand: expand,
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
            ProcessListExtractJobsApiV2ExtractGetResponse(
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
                ProcessListExtractJobsApiV2ExtractGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ExtractV2JobQueryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ExtractV2JobQueryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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