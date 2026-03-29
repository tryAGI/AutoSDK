//HintName: G.BetaClient.UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {
        partial void PrepareUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string directoryId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::G.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost request);
        partial void PrepareUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string directoryId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::G.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost request);
        partial void ProcessUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file directly to a directory.<br/>
        /// Uploads a file and creates a directory file entry in a single operation.<br/>
        /// If unique_id or display_name are not provided, they will be derived from the file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,

            global::G.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostArguments(
                httpClient: HttpClient,
                directoryId: ref directoryId,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/beta/directories/{directoryId}/files/upload",
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{directoryId}"),
                name: "\"directory_id\"");
            if (projectId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{projectId}"),
                    name: "\"project_id\"");
            } 
            if (organizationId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{organizationId}"),
                    name: "\"organization_id\"");
            } 
            if (session != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{session}"),
                    name: "\"session\"");
            }
            var __contentUploadFile = new global::System.Net.Http.ByteArrayContent(request.UploadFile ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentUploadFile,
                name: "\"upload_file\"",
                fileName: request.UploadFilename != null ? $"\"{request.UploadFilename}\"" : string.Empty);
            if (__contentUploadFile.Headers.ContentDisposition != null)
            {
                __contentUploadFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.UniqueId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UniqueId}"),
                    name: "\"unique_id\"");
            } 
            if (request.DisplayName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DisplayName}"),
                    name: "\"display_name\"");
            } 
            if (request.ExternalFileId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExternalFileId}"),
                    name: "\"external_file_id\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                directoryId: directoryId,
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
            ProcessUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostResponse(
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
                ProcessUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DirectoryFileResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DirectoryFileResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Upload File To Directory<br/>
        /// Upload a file directly to a directory.<br/>
        /// Uploads a file and creates a directory file entry in a single operation.<br/>
        /// If unique_id or display_name are not provided, they will be derived from the file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        /// <param name="uniqueId"></param>
        /// <param name="displayName"></param>
        /// <param name="externalFileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,
            byte[] uploadFile,
            string uploadFilename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? externalFileId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost
            {
                UploadFile = uploadFile,
                UploadFilename = uploadFilename,
                UniqueId = uniqueId,
                DisplayName = displayName,
                ExternalFileId = externalFileId,
            };

            return await UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
                directoryId: directoryId,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}