//HintName: G.FileClient.FileStoreProjectFileString.g.cs

#nullable enable

namespace G
{
    public partial class FileClient
    {
        partial void PrepareFileStoreProjectFileStringArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref int? fileStorageType,
            ref string? extension,
            ref string? text);
        partial void PrepareFileStoreProjectFileStringRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            int? fileStorageType,
            string? extension,
            string? text);
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
            string? token = default,
            global::System.Guid? projectId = default,
            int? fileStorageType = default,
            string? extension = default,
            string? text = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFileStoreProjectFileStringArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                fileStorageType: ref fileStorageType,
                extension: ref extension,
                text: ref text);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/file/storeprojectfilestring",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("fileStorageType", fileStorageType?.ToString()) 
                .AddOptionalParameter("extension", extension) 
                .AddOptionalParameter("text", text) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFileStoreProjectFileStringRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                fileStorageType: fileStorageType,
                extension: extension,
                text: text);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFileStoreProjectFileStringResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessFileStoreProjectFileStringResponseContent(
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

            return __content;
        }
    }
}