//HintName: G.LibraryManagementClient.V1LibraryUpload.g.cs

#nullable enable

namespace G
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            global::G.BodyV1LibraryUpload request);
        partial void PrepareV1LibraryUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
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
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileUploadResponse> V1LibraryUploadAsync(
            global::G.BodyV1LibraryUpload request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1LibraryUploadArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/library/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (requestStartTime != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{requestStartTime}"),
                    name: "request_start_time");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
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
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1LibraryUploadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestStartTime: requestStartTime,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1LibraryUploadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessV1LibraryUploadResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                return
                    global::G.FileUploadResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.FileUploadResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
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
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
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
            int? requestStartTime = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            string? publicUrl = default,
            string? customConfigs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyV1LibraryUpload
            {
                File = file,
                Filename = filename,
                Path = path,
                Labels = labels,
                PublicUrl = publicUrl,
                CustomConfigs = customConfigs,
            };

            return await V1LibraryUploadAsync(
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}