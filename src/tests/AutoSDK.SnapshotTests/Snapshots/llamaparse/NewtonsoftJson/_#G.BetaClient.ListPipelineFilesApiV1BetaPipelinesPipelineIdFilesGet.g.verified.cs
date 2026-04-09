//HintName: G.BetaClient.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGet.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetSecurityRequirement0,
            };
        partial void PrepareListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid pipelineId,
            global::System.Guid? dataSourceId,
            ref string? fileNameContains,
            global::System.Collections.Generic.IList<global::G.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? statuses,
            int? pageSize,
            ref string? pageToken,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session);
        partial void PrepareListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId,
            string? fileNameContains,
            global::System.Collections.Generic.IList<global::G.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? statuses,
            int? pageSize,
            string? pageToken,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session);
        partial void ProcessListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Pipeline Files<br/>
        /// List files for a pipeline with pagination and filtering.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="dataSourceId">
        /// Filter by data source ID.
        /// </param>
        /// <param name="fileNameContains">
        /// Filter by files whose names contain this substring (case-insensitive).
        /// </param>
        /// <param name="statuses">
        /// Filter by pipeline file statuses.
        /// </param>
        /// <param name="pageSize">
        /// Maximum number of items to return. Defaults to 50, max 1000.
        /// </param>
        /// <param name="pageToken">
        /// Page token for pagination, from a previous response.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PipelineFileListResponse> ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetAsync(
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId = default,
            string? fileNameContains = default,
            global::System.Collections.Generic.IList<global::G.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? statuses = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                dataSourceId: dataSourceId,
                fileNameContains: ref fileNameContains,
                statuses: statuses,
                pageSize: pageSize,
                pageToken: ref pageToken,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetSecurityRequirements,
                operationName: "ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/beta/pipelines/{pipelineId}/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("data_source_id", dataSourceId?.ToString())
                .AddOptionalParameter("file_name_contains", fileNameContains)
                .AddOptionalParameter("statuses", statuses?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("page_token", pageToken)
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
            PrepareListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                dataSourceId: dataSourceId,
                fileNameContains: fileNameContains,
                statuses: statuses,
                pageSize: pageSize,
                pageToken: pageToken,
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
            ProcessListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetResponse(
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
                ProcessListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PipelineFileListResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PipelineFileListResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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