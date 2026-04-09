//HintName: G.FoldersClient.UploadFileToFolder.g.cs

#nullable enable

namespace G
{
    public partial class FoldersClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_UploadFileToFolderSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_UploadFileToFolderSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_UploadFileToFolderSecurityRequirement0,
            };
        partial void PrepareUploadFileToFolderArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string folderId,
            ref global::G.DuplicateFileHandling? duplicateHandling,
            ref string? name,
            global::G.BodyUploadFileToFolder request);
        partial void PrepareUploadFileToFolderRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string folderId,
            global::G.DuplicateFileHandling? duplicateHandling,
            string? name,
            global::G.BodyUploadFileToFolder request);
        partial void ProcessUploadFileToFolderResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadFileToFolderResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload File To Folder<br/>
        /// Upload a file to a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="duplicateHandling">
        /// How to handle duplicate filenames<br/>
        /// Default Value: suffix
        /// </param>
        /// <param name="name">
        /// Optional custom name to override the uploaded file's name
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileMetadata> UploadFileToFolderAsync(
            string folderId,

            global::G.BodyUploadFileToFolder request,
            global::G.DuplicateFileHandling? duplicateHandling = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadFileToFolderArguments(
                httpClient: HttpClient,
                folderId: ref folderId,
                duplicateHandling: ref duplicateHandling,
                name: ref name,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadFileToFolderSecurityRequirements,
                operationName: "UploadFileToFolderAsync");

            var duplicateHandlingValue = duplicateHandling switch
            {
                global::G.DuplicateFileHandling.Skip => "skip",
                global::G.DuplicateFileHandling.Error => "error",
                global::G.DuplicateFileHandling.Suffix => "suffix",
                global::G.DuplicateFileHandling.Replace => "replace",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/folders/{folderId}/upload",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("duplicate_handling", duplicateHandling?.ToValueString())
                .AddOptionalParameter("name", name) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{folderId}"),
                name: "\"folder_id\"");
            if (duplicateHandling != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{duplicateHandling?.ToValueString()}"),
                    name: "\"duplicate_handling\"");
            } 
            if (name != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{name}"),
                    name: "\"name\"");
            }
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadFileToFolderRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                folderId: folderId,
                duplicateHandling: duplicateHandling,
                name: name,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadFileToFolderResponse(
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
                ProcessUploadFileToFolderResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.FileMetadata.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.FileMetadata.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Upload File To Folder<br/>
        /// Upload a file to a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="duplicateHandling">
        /// How to handle duplicate filenames<br/>
        /// Default Value: suffix
        /// </param>
        /// <param name="name">
        /// Optional custom name to override the uploaded file's name
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileMetadata> UploadFileToFolderAsync(
            string folderId,
            byte[] file,
            string filename,
            global::G.DuplicateFileHandling? duplicateHandling = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyUploadFileToFolder
            {
                File = file,
                Filename = filename,
            };

            return await UploadFileToFolderAsync(
                folderId: folderId,
                duplicateHandling: duplicateHandling,
                name: name,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}