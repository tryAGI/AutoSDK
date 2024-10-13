//HintName: G.FilesClient.FilesApiRoutesUploadFile.g.cs

#nullable enable

namespace G
{
    public partial class FilesClient
    {
        partial void PrepareFilesApiRoutesUploadFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.FilesApiRoutesUploadFileRequest request);
        partial void PrepareFilesApiRoutesUploadFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.FilesApiRoutesUploadFileRequest request);
        partial void ProcessFilesApiRoutesUploadFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFilesApiRoutesUploadFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload File<br/>
        /// Upload a file that can be used across various endpoints.<br/>
        /// The size of individual files can be a maximum of 512 MB. The Fine-tuning API only supports .jsonl files.<br/>
        /// Please contact us if you need to increase these storage limits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadFileOut> FilesApiRoutesUploadFileAsync(
            global::G.FilesApiRoutesUploadFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareFilesApiRoutesUploadFileArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/files",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "file",
                fileName: request.Filename ?? string.Empty);
            if (request.Purpose != global::G.FilesApiRoutesUploadFileRequestPurpose.FineTune)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Purpose?.ToValueString()}"),
                    name: "purpose");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareFilesApiRoutesUploadFileRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessFilesApiRoutesUploadFileResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessFilesApiRoutesUploadFileResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.UploadFileOut.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload File<br/>
        /// Upload a file that can be used across various endpoints.<br/>
        /// The size of individual files can be a maximum of 512 MB. The Fine-tuning API only supports .jsonl files.<br/>
        /// Please contact us if you need to increase these storage limits.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </param>
        /// <param name="purpose">
        /// Default Value: fine-tune
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadFileOut> FilesApiRoutesUploadFileAsync(
            byte[] file,
            string filename,
            global::G.FilesApiRoutesUploadFileRequestPurpose? purpose = global::G.FilesApiRoutesUploadFileRequestPurpose.FineTune,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.FilesApiRoutesUploadFileRequest
            {
                File = file,
                Filename = filename,
                Purpose = purpose,
            };

            return await FilesApiRoutesUploadFileAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}