//HintName: G.LibraryManagementClient.V1LibraryManagement2.g.cs

#nullable enable

namespace G
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryManagement2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid fileId);
        partial void PrepareV1LibraryManagement2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid fileId);
        partial void ProcessV1LibraryManagement2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibraryManagement2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get File By Id<br/>
        /// Retrieve a list of documents in the user's library. Optionally specify a<br/>
        /// filter to find only files with matching labels or paths. This method<br/>
        /// returns only metadata about files; to download a file, call<br/>
        /// `GET .../files/{file_id}/download`<br/>
        /// When specifying qualifiers with your request, only files that match<br/>
        /// _all_ qualifiers will be returns. So, for example, if you specify<br/>
        /// `label='financial'` and `status='UPLOADED'`, only files with the label<br/>
        /// "financial" AND status UPLOADED will be returned.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileResponse> V1LibraryManagement2Async(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1LibraryManagement2Arguments(
                httpClient: HttpClient,
                fileId: ref fileId);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/library/files/{fileId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1LibraryManagement2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileId: fileId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1LibraryManagement2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1LibraryManagement2ResponseContent(
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
                global::G.FileResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}