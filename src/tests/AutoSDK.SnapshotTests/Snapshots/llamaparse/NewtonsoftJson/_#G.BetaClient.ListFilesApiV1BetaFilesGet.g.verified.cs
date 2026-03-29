//HintName: G.BetaClient.ListFilesApiV1BetaFilesGet.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {
        partial void PrepareListFilesApiV1BetaFilesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            int? pageSize,
            ref string? pageToken,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            ref string? fileName,
            ref string? externalFileId,
            ref string? orderBy,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session);
        partial void PrepareListFilesApiV1BetaFilesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? pageToken,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            string? fileName,
            string? externalFileId,
            string? orderBy,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session);
        partial void ProcessListFilesApiV1BetaFilesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFilesApiV1BetaFilesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Files<br/>
        /// List files with optional filtering and pagination.<br/>
        /// Filter by `file_name`, `file_ids`, or `external_file_id`.<br/>
        /// Supports cursor-based pagination and custom ordering.
        /// </summary>
        /// <param name="pageSize">
        /// The maximum number of items to return. Defaults to 50, maximum is 1000.
        /// </param>
        /// <param name="pageToken">
        /// A page token received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="fileIds">
        /// Filter by specific file IDs.
        /// </param>
        /// <param name="fileName">
        /// Filter by file name (exact match).
        /// </param>
        /// <param name="externalFileId">
        /// Filter by external file ID.
        /// </param>
        /// <param name="orderBy">
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileQueryResponseV2> ListFilesApiV1BetaFilesGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            string? fileName = default,
            string? externalFileId = default,
            string? orderBy = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListFilesApiV1BetaFilesGetArguments(
                httpClient: HttpClient,
                pageSize: pageSize,
                pageToken: ref pageToken,
                fileIds: fileIds,
                fileName: ref fileName,
                externalFileId: ref externalFileId,
                orderBy: ref orderBy,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/beta/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("page_token", pageToken)
                .AddOptionalParameter("file_ids", fileIds?.ToString())
                .AddOptionalParameter("file_name", fileName)
                .AddOptionalParameter("external_file_id", externalFileId)
                .AddOptionalParameter("order_by", orderBy)
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
            PrepareListFilesApiV1BetaFilesGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                pageToken: pageToken,
                fileIds: fileIds,
                fileName: fileName,
                externalFileId: externalFileId,
                orderBy: orderBy,
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
            ProcessListFilesApiV1BetaFilesGetResponse(
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
                ProcessListFilesApiV1BetaFilesGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.FileQueryResponseV2.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.FileQueryResponseV2.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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