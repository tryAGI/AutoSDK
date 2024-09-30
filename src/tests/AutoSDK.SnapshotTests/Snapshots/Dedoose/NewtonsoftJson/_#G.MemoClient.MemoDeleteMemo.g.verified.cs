//HintName: G.MemoClient.MemoDeleteMemo.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoDeleteMemoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? id,
            ref global::System.Guid? projectId,
            ref string? title,
            ref global::System.Guid? createdUserId,
            ref global::System.Guid? lastEditUserId,
            ref global::System.DateTime? createStamp,
            ref global::System.DateTime? lastEditStamp,
            ref global::System.Guid? folderId,
            ref string? dataURI);
        partial void PrepareMemoDeleteMemoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? title,
            global::System.Guid? createdUserId,
            global::System.Guid? lastEditUserId,
            global::System.DateTime? createStamp,
            global::System.DateTime? lastEditStamp,
            global::System.Guid? folderId,
            string? dataURI);
        partial void ProcessMemoDeleteMemoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoDeleteMemoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteMemo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="createdUserId"></param>
        /// <param name="lastEditUserId"></param>
        /// <param name="createStamp"></param>
        /// <param name="lastEditStamp"></param>
        /// <param name="folderId"></param>
        /// <param name="dataURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Memo> MemoDeleteMemoAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? id = default,
            global::System.Guid? projectId = default,
            string? title = default,
            global::System.Guid? createdUserId = default,
            global::System.Guid? lastEditUserId = default,
            global::System.DateTime? createStamp = default,
            global::System.DateTime? lastEditStamp = default,
            global::System.Guid? folderId = default,
            string? dataURI = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoDeleteMemoArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                projectId: ref projectId,
                title: ref title,
                createdUserId: ref createdUserId,
                lastEditUserId: ref lastEditUserId,
                createStamp: ref createStamp,
                lastEditStamp: ref lastEditStamp,
                folderId: ref folderId,
                dataURI: ref dataURI);

            if (token != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("token", token.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/memo/deletememo",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("Title", title) 
                .AddOptionalParameter("CreatedUserId", createdUserId?.ToString()) 
                .AddOptionalParameter("LastEditUserId", lastEditUserId?.ToString()) 
                .AddOptionalParameter("CreateStamp", createStamp?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("LastEditStamp", lastEditStamp?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("FolderId", folderId?.ToString()) 
                .AddOptionalParameter("DataURI", dataURI) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoDeleteMemoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                projectId: projectId,
                title: title,
                createdUserId: createdUserId,
                lastEditUserId: lastEditUserId,
                createStamp: createStamp,
                lastEditStamp: lastEditStamp,
                folderId: folderId,
                dataURI: dataURI);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoDeleteMemoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoDeleteMemoResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Memo?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}