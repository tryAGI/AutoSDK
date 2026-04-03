//HintName: G.AttachmentsClient.DownloadAttachment.g.cs

#nullable enable

namespace G
{
    public partial class AttachmentsClient
    {
        partial void PrepareDownloadAttachmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? workspaceName,
            ref global::System.Guid containerId,
            ref global::G.DownloadAttachmentEntityType entityType,
            ref global::System.Guid entityId,
            ref string fileName,
            ref string mimeType);
        partial void PrepareDownloadAttachmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? workspaceName,
            global::System.Guid containerId,
            global::G.DownloadAttachmentEntityType entityType,
            global::System.Guid entityId,
            string fileName,
            string mimeType);
        partial void ProcessDownloadAttachmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDownloadAttachmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Download attachment from MinIO<br/>
        /// Download attachment from MinIO
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="containerId"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="fileName"></param>
        /// <param name="mimeType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> DownloadAttachmentAsync(
            global::System.Guid containerId,
            global::G.DownloadAttachmentEntityType entityType,
            global::System.Guid entityId,
            string fileName,
            string mimeType,
            string? workspaceName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDownloadAttachmentArguments(
                httpClient: HttpClient,
                workspaceName: ref workspaceName,
                containerId: ref containerId,
                entityType: ref entityType,
                entityId: ref entityId,
                fileName: ref fileName,
                mimeType: ref mimeType);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/attachment/download",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("workspace_name", workspaceName)
                .AddRequiredParameter("container_id", containerId.ToString()!)
                .AddRequiredParameter("entity_type", entityType.ToValueString())
                .AddRequiredParameter("entity_id", entityId.ToString()!)
                .AddRequiredParameter("file_name", fileName)
                .AddRequiredParameter("mime_type", mimeType) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDownloadAttachmentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workspaceName: workspaceName,
                containerId: containerId,
                entityType: entityType,
                entityId: entityId,
                fileName: fileName,
                mimeType: mimeType);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDownloadAttachmentResponse(
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
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessDownloadAttachmentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
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
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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