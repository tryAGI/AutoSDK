//HintName: G.MemoClient.MemoAddMemo.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoAddMemoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref string? title,
            ref string? dataPath,
            global::System.Collections.Generic.IList<global::System.Guid>? folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags);
        partial void PrepareMemoAddMemoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            string? title,
            string? dataPath,
            global::System.Collections.Generic.IList<global::System.Guid>? folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags);
        partial void ProcessMemoAddMemoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoAddMemoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddMemo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="dataPath"></param>
        /// <param name="folderIds"></param>
        /// <param name="resources"></param>
        /// <param name="excerpts"></param>
        /// <param name="descriptors"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MemoAndLinks> MemoAddMemoAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            string? dataPath = default,
            global::System.Collections.Generic.IList<global::System.Guid>? folderIds = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoAddMemoArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                title: ref title,
                dataPath: ref dataPath,
                folderIds: folderIds,
                resources: resources,
                excerpts: excerpts,
                descriptors: descriptors,
                tags: tags);

            if (token != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("token", token.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/memo/addmemo",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("dataPath", dataPath) 
                .AddOptionalParameter("folderIds", folderIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoAddMemoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                title: title,
                dataPath: dataPath,
                folderIds: folderIds,
                resources: resources,
                excerpts: excerpts,
                descriptors: descriptors,
                tags: tags);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoAddMemoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoAddMemoResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.MemoAndLinks?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}