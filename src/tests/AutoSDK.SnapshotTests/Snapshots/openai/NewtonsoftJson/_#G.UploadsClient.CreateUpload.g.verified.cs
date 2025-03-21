//HintName: G.UploadsClient.CreateUpload.g.cs

#nullable enable

namespace G
{
    public partial class UploadsClient
    {
        partial void PrepareCreateUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateUploadRequest request);
        partial void PrepareCreateUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateUploadRequest request);
        partial void ProcessCreateUploadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateUploadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object<br/>
        /// that you can add [Parts](/docs/api-reference/uploads/part-object) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](/docs/api-reference/files/object) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified. <br/>
        /// Please refer to documentation for the <br/>
        /// [supported MIME types for your use case](/docs/assistants/tools/file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](/docs/api-reference/files/create).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Upload> CreateUploadAsync(
            global::G.CreateUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateUploadArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/uploads",
                baseUri: HttpClient.BaseAddress); 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateUploadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateUploadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessCreateUploadResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.Upload.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.Upload.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object<br/>
        /// that you can add [Parts](/docs/api-reference/uploads/part-object) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](/docs/api-reference/files/object) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified. <br/>
        /// Please refer to documentation for the <br/>
        /// [supported MIME types for your use case](/docs/assistants/tools/file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](/docs/api-reference/files/create).
        /// </summary>
        /// <param name="bytes">
        /// The number of bytes in the file you are uploading.
        /// </param>
        /// <param name="filename">
        /// The name of the file to upload.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.<br/>
        /// This must fall within the supported MIME types for your file purpose. See the supported MIME types for assistants and vision.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// See the [documentation on File purposes](/docs/api-reference/files/create#files-create-purpose).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Upload> CreateUploadAsync(
            int bytes,
            string filename,
            string mimeType,
            global::G.CreateUploadRequestPurpose purpose,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateUploadRequest
            {
                Bytes = bytes,
                Filename = filename,
                MimeType = mimeType,
                Purpose = purpose,
            };

            return await CreateUploadAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}