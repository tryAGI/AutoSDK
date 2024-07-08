//HintName: G.FileClient.FileStoreProjectFileString.g.cs

#nullable enable

namespace G
{
    public partial class FileClient
    {
        partial void PrepareFileStoreProjectFileStringArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref int fileStorageType,
            ref string extension,
            ref string text);
        partial void PrepareFileStoreProjectFileStringRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            int fileStorageType,
            string extension,
            string text);
        partial void ProcessFileStoreProjectFileStringResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFileStoreProjectFileStringResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StoreProjectFileString.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileStorageType"></param>
        /// <param name="extension"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> FileStoreProjectFileStringAsync(
            string token,
            string projectId,
            int fileStorageType,
            string extension,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareFileStoreProjectFileStringArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                fileStorageType: ref fileStorageType,
                extension: ref extension,
                text: ref text);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/file/storeprojectfilestring?projectId={projectId}&fileStorageType={fileStorageType}&extension={extension}&text={text}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareFileStoreProjectFileStringRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                fileStorageType: fileStorageType,
                extension: extension,
                text: text);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessFileStoreProjectFileStringResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessFileStoreProjectFileStringResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}