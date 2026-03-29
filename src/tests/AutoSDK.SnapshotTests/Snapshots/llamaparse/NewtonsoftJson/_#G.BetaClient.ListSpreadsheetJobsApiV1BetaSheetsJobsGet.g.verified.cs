//HintName: G.BetaClient.ListSpreadsheetJobsApiV1BetaSheetsJobsGet.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {
        partial void PrepareListSpreadsheetJobsApiV1BetaSheetsJobsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? includeResults,
            global::G.StatusEnum? status,
            global::System.DateTime? createdAtOnOrAfter,
            global::System.DateTime? createdAtOnOrBefore,
            global::System.Collections.Generic.IList<string>? jobIds,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            int? pageSize,
            ref string? pageToken,
            ref string? session);
        partial void PrepareListSpreadsheetJobsApiV1BetaSheetsJobsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? includeResults,
            global::G.StatusEnum? status,
            global::System.DateTime? createdAtOnOrAfter,
            global::System.DateTime? createdAtOnOrBefore,
            global::System.Collections.Generic.IList<string>? jobIds,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            int? pageSize,
            string? pageToken,
            string? session);
        partial void ProcessListSpreadsheetJobsApiV1BetaSheetsJobsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListSpreadsheetJobsApiV1BetaSheetsJobsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Spreadsheet Jobs<br/>
        /// List spreadsheet parsing jobs.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="includeResults">
        /// Default Value: false
        /// </param>
        /// <param name="status">
        /// Filter by job status
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
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedResponseSpreadsheetJob> ListSpreadsheetJobsApiV1BetaSheetsJobsGetAsync(
            bool? includeResults = default,
            global::G.StatusEnum? status = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListSpreadsheetJobsApiV1BetaSheetsJobsGetArguments(
                httpClient: HttpClient,
                includeResults: ref includeResults,
                status: status,
                createdAtOnOrAfter: createdAtOnOrAfter,
                createdAtOnOrBefore: createdAtOnOrBefore,
                jobIds: jobIds,
                projectId: projectId,
                organizationId: organizationId,
                pageSize: pageSize,
                pageToken: ref pageToken,
                session: ref session);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/beta/sheets/jobs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("include_results", includeResults?.ToString().ToLowerInvariant())
                .AddOptionalParameter("status", status?.ToString())
                .AddOptionalParameter("created_at_on_or_after", createdAtOnOrAfter?.ToString())
                .AddOptionalParameter("created_at_on_or_before", createdAtOnOrBefore?.ToString())
                .AddOptionalParameter("job_ids", jobIds?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("page_token", pageToken) 
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
            PrepareListSpreadsheetJobsApiV1BetaSheetsJobsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                includeResults: includeResults,
                status: status,
                createdAtOnOrAfter: createdAtOnOrAfter,
                createdAtOnOrBefore: createdAtOnOrBefore,
                jobIds: jobIds,
                projectId: projectId,
                organizationId: organizationId,
                pageSize: pageSize,
                pageToken: pageToken,
                session: session);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListSpreadsheetJobsApiV1BetaSheetsJobsGetResponse(
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
                ProcessListSpreadsheetJobsApiV1BetaSheetsJobsGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedResponseSpreadsheetJob.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PaginatedResponseSpreadsheetJob.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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