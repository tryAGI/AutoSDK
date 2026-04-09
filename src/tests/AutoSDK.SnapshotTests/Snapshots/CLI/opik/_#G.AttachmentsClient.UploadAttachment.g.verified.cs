//HintName: G.AttachmentsClient.UploadAttachment.g.cs

#nullable enable

namespace G
{
    public partial class AttachmentsClient
    {
        partial void PrepareUploadAttachmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fileName,
            ref string? projectName,
            ref string? mimeType,
            ref global::G.UploadAttachmentEntityType entityType,
            ref global::System.Guid entityId,
            object request);
        partial void PrepareUploadAttachmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fileName,
            string? projectName,
            string? mimeType,
            global::G.UploadAttachmentEntityType entityType,
            global::System.Guid entityId,
            object request);
        partial void ProcessUploadAttachmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Upload attachment to MinIO<br/>
        /// Upload attachment to MinIO
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="mimeType"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UploadAttachmentAsync(
            string fileName,
            global::G.UploadAttachmentEntityType entityType,
            global::System.Guid entityId,

            object request,
            string? projectName = default,
            string? mimeType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadAttachmentArguments(
                httpClient: HttpClient,
                fileName: ref fileName,
                projectName: ref projectName,
                mimeType: ref mimeType,
                entityType: ref entityType,
                entityId: ref entityId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/attachment/upload",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("file_name", fileName)
                .AddOptionalParameter("project_name", projectName)
                .AddOptionalParameter("mime_type", mimeType)
                .AddRequiredParameter("entity_type", entityType.ToValueString())
                .AddRequiredParameter("entity_id", entityId.ToString()!) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "*/*");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadAttachmentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileName: fileName,
                projectName: projectName,
                mimeType: mimeType,
                entityType: entityType,
                entityId: entityId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadAttachmentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.ErrorMessage? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.ErrorMessage.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.ErrorMessage.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorMessage>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Access forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.ErrorMessage? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.ErrorMessage.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.ErrorMessage.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorMessage>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Upload attachment to MinIO<br/>
        /// Upload attachment to MinIO
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="mimeType"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UploadAttachmentAsync(
            string fileName,
            global::G.UploadAttachmentEntityType entityType,
            global::System.Guid entityId,
            string? projectName = default,
            string? mimeType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new object
            {
            };

            await UploadAttachmentAsync(
                fileName: fileName,
                projectName: projectName,
                mimeType: mimeType,
                entityType: entityType,
                entityId: entityId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}