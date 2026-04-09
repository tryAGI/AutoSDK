//HintName: G.PipelineFilesClient.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2Get.g.cs

#nullable enable

namespace G
{
    public partial class PipelineFilesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HTTPBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetSecurityRequirement0,
            };
        partial void PrepareListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid pipelineId,
            global::System.Guid? dataSourceId,
            ref bool? onlyManuallyUploaded,
            ref string? fileNameContains,
            global::System.Collections.Generic.IList<global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? statuses,
            int? limit,
            int? offset,
            ref string? orderBy,
            ref string? session);
        partial void PrepareListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId,
            bool? onlyManuallyUploaded,
            string? fileNameContains,
            global::System.Collections.Generic.IList<global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? statuses,
            int? limit,
            int? offset,
            string? orderBy,
            string? session);
        partial void ProcessListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Pipeline Files2<br/>
        /// List files for a pipeline with optional filtering, sorting, and pagination.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="onlyManuallyUploaded">
        /// Default Value: false
        /// </param>
        /// <param name="fileNameContains"></param>
        /// <param name="statuses">
        /// Filter by file statuses
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="orderBy"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.PaginatedListPipelineFilesResponse> ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetAsync(
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId = default,
            bool? onlyManuallyUploaded = default,
            string? fileNameContains = default,
            global::System.Collections.Generic.IList<global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? statuses = default,
            int? limit = default,
            int? offset = default,
            string? orderBy = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                dataSourceId: dataSourceId,
                onlyManuallyUploaded: ref onlyManuallyUploaded,
                fileNameContains: ref fileNameContains,
                statuses: statuses,
                limit: limit,
                offset: offset,
                orderBy: ref orderBy,
                session: ref session);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetSecurityRequirements,
                operationName: "ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/pipelines/{pipelineId}/files2",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("data_source_id", dataSourceId?.ToString())
                .AddOptionalParameter("only_manually_uploaded", onlyManuallyUploaded?.ToString().ToLowerInvariant())
                .AddOptionalParameter("file_name_contains", fileNameContains)
                .AddOptionalParameter("statuses", statuses?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("order_by", orderBy) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                dataSourceId: dataSourceId,
                onlyManuallyUploaded: onlyManuallyUploaded,
                fileNameContains: fileNameContains,
                statuses: statuses,
                limit: limit,
                offset: offset,
                orderBy: orderBy,
                session: session);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetResponse(
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
                ProcessListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedListPipelineFilesResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PaginatedListPipelineFilesResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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