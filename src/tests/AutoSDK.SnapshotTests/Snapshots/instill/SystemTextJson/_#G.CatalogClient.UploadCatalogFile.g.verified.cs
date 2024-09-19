//HintName: G.CatalogClient.UploadCatalogFile.g.cs

#nullable enable

namespace G
{
    public partial class CatalogClient
    {
        partial void PrepareUploadCatalogFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string catalogId,
            global::G.File request);
        partial void PrepareUploadCatalogFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string catalogId,
            global::G.File request);
        partial void ProcessUploadCatalogFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadCatalogFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            global::G.File request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadCatalogFileArguments(
                httpClient: _httpClient,
                namespaceId: ref namespaceId,
                catalogId: ref catalogId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/catalogs/{catalogId}/files",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadCatalogFileRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                namespaceId: namespaceId,
                catalogId: catalogId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUploadCatalogFileResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadCatalogFileResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UploadCatalogFileResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="processStatus"></param>
        /// <param name="processOutcome"></param>
        /// <param name="retrievable"></param>
        /// <param name="content"></param>
        /// <param name="ownerUid"></param>
        /// <param name="creatorUid"></param>
        /// <param name="catalogUid"></param>
        /// <param name="createTime"></param>
        /// <param name="updateTime"></param>
        /// <param name="deleteTime"></param>
        /// <param name="size"></param>
        /// <param name="totalChunks"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            string name,
            global::G.AllOf<global::G.FileType2?> type,
            string? fileUid = default,
            global::G.AllOf<global::G.FileProcessStatus2?>? processStatus = default,
            string? processOutcome = default,
            bool? retrievable = default,
            string? content = default,
            string? ownerUid = default,
            string? creatorUid = default,
            string? catalogUid = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            global::System.DateTime? deleteTime = default,
            string? size = default,
            int? totalChunks = default,
            int? totalTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.File
            {
                FileUid = fileUid,
                Name = name,
                Type = type,
                ProcessStatus = processStatus,
                ProcessOutcome = processOutcome,
                Retrievable = retrievable,
                Content = content,
                OwnerUid = ownerUid,
                CreatorUid = creatorUid,
                CatalogUid = catalogUid,
                CreateTime = createTime,
                UpdateTime = updateTime,
                DeleteTime = deleteTime,
                Size = size,
                TotalChunks = totalChunks,
                TotalTokens = totalTokens,
            };

            return await UploadCatalogFileAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}