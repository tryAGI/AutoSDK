//HintName: G.Api.FileSearchStoresImportFile.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareFileSearchStoresImportFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fileSearchStoresId,
            global::G.ImportFileRequest request);
        partial void PrepareFileSearchStoresImportFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fileSearchStoresId,
            global::G.ImportFileRequest request);
        partial void ProcessFileSearchStoresImportFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFileSearchStoresImportFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Operation> FileSearchStoresImportFileAsync(
            string fileSearchStoresId,

            global::G.ImportFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFileSearchStoresImportFileArguments(
                httpClient: HttpClient,
                fileSearchStoresId: ref fileSearchStoresId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/fileSearchStores/{fileSearchStoresId}:importFile",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFileSearchStoresImportFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileSearchStoresId: fileSearchStoresId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFileSearchStoresImportFileResponse(
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
                ProcessFileSearchStoresImportFileResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Operation.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Operation.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="fileName">
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the file.
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Operation> FileSearchStoresImportFileAsync(
            string fileSearchStoresId,
            string? fileName = default,
            global::System.Collections.Generic.IList<global::G.CustomMetadata>? customMetadata = default,
            global::G.ChunkingConfig? chunkingConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ImportFileRequest
            {
                FileName = fileName,
                CustomMetadata = customMetadata,
                ChunkingConfig = chunkingConfig,
            };

            return await FileSearchStoresImportFileAsync(
                fileSearchStoresId: fileSearchStoresId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}