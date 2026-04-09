//HintName: G.BetaClient.ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirement0,
            };
        partial void PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string directoryId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? displayName,
            ref string? displayNameContains,
            ref string? uniqueId,
            ref string? fileId,
            ref bool? includeDeleted,
            int? pageSize,
            ref string? pageToken,
            ref string? session);
        partial void PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string directoryId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? displayName,
            string? displayNameContains,
            string? uniqueId,
            string? fileId,
            bool? includeDeleted,
            int? pageSize,
            string? pageToken,
            string? session);
        partial void ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Directory Files<br/>
        /// List all files within the specified directory with optional filtering and pagination.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="displayName"></param>
        /// <param name="displayNameContains"></param>
        /// <param name="uniqueId"></param>
        /// <param name="fileId"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DirectoryFileQueryResponse> ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync(
            string directoryId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? displayName = default,
            string? displayNameContains = default,
            string? uniqueId = default,
            string? fileId = default,
            bool? includeDeleted = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetArguments(
                httpClient: HttpClient,
                directoryId: ref directoryId,
                projectId: projectId,
                organizationId: organizationId,
                displayName: ref displayName,
                displayNameContains: ref displayNameContains,
                uniqueId: ref uniqueId,
                fileId: ref fileId,
                includeDeleted: ref includeDeleted,
                pageSize: pageSize,
                pageToken: ref pageToken,
                session: ref session);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirements,
                operationName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/beta/directories/{directoryId}/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString())
                .AddOptionalParameter("display_name", displayName)
                .AddOptionalParameter("display_name_contains", displayNameContains)
                .AddOptionalParameter("unique_id", uniqueId)
                .AddOptionalParameter("file_id", fileId)
                .AddOptionalParameter("include_deleted", includeDeleted?.ToString().ToLowerInvariant())
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

            foreach (var __authorization in __authorizations)
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
            PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                directoryId: directoryId,
                projectId: projectId,
                organizationId: organizationId,
                displayName: displayName,
                displayNameContains: displayNameContains,
                uniqueId: uniqueId,
                fileId: fileId,
                includeDeleted: includeDeleted,
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
            ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponse(
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
                ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DirectoryFileQueryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DirectoryFileQueryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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