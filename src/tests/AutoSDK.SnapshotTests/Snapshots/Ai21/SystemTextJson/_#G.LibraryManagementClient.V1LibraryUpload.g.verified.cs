//HintName: G.LibraryManagementClient.V1LibraryUpload.g.cs

#nullable enable

namespace G
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyV1LibraryUpload request);
        partial void PrepareV1LibraryUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyV1LibraryUpload request);
        partial void ProcessV1LibraryUploadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibraryUploadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Organization File<br/>
        /// Upload files to use for [RAG Engine document searches](https://docs.ai21.com/docs/rag-engine-overview).<br/>
        /// You can assign metadata to your files to limit searches to specific files by file metadata.<br/>
        /// There is no bulk upload method; files must be loaded one at a time.<br/>
        /// - **Max number of files:** No limit. The playground limits bulk uploads to 50 files per request.<br/>
        /// - **Max library size:** 1 GB total size. No limit to individual file size.<br/>
        /// - **Supported file types:** PDF, DocX, HTML, TXT
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileUploadResponse> V1LibraryUploadAsync(
            global::G.BodyV1LibraryUpload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1LibraryUploadArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/library/files",
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
            if (request.Path != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Path}"),
                    name: "path");
            } 
            if (request.Labels != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Labels, x => x))}]"),
                    name: "labels");
            } 
            if (request.PublicUrl != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PublicUrl}"),
                    name: "publicUrl");
            } 
            if (request.CustomConfigs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CustomConfigs}"),
                    name: "custom_configs");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1LibraryUploadRequest(
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
            ProcessV1LibraryUploadResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1LibraryUploadResponseContent(
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
                global::G.FileUploadResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload Organization File<br/>
        /// Upload files to use for [RAG Engine document searches](https://docs.ai21.com/docs/rag-engine-overview).<br/>
        /// You can assign metadata to your files to limit searches to specific files by file metadata.<br/>
        /// There is no bulk upload method; files must be loaded one at a time.<br/>
        /// - **Max number of files:** No limit. The playground limits bulk uploads to 50 files per request.<br/>
        /// - **Max library size:** 1 GB total size. No limit to individual file size.<br/>
        /// - **Supported file types:** PDF, DocX, HTML, TXT
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="publicUrl"></param>
        /// <param name="customConfigs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileUploadResponse> V1LibraryUploadAsync(
            byte[] file,
            string filename,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            string? publicUrl = default,
            string? customConfigs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyV1LibraryUpload
            {
                File = file,
                Filename = filename,
                Path = path,
                Labels = labels,
                PublicUrl = publicUrl,
                CustomConfigs = customConfigs,
            };

            return await V1LibraryUploadAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}