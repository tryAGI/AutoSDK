//HintName: G.MemoClient.MemoUpdateMemo.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoUpdateMemoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid id,
            ref global::System.Guid projectId,
            ref string? title,
            ref global::System.Guid createdUserId,
            ref global::System.Guid lastEditUserId,
            ref global::System.DateTime createStamp,
            ref global::System.DateTime lastEditStamp,
            ref global::System.Guid folderId,
            ref string? dataURI,
            global::System.Collections.Generic.IList<global::System.Guid>? folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags);
        partial void PrepareMemoUpdateMemoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid id,
            global::System.Guid projectId,
            string? title,
            global::System.Guid createdUserId,
            global::System.Guid lastEditUserId,
            global::System.DateTime createStamp,
            global::System.DateTime lastEditStamp,
            global::System.Guid folderId,
            string? dataURI,
            global::System.Collections.Generic.IList<global::System.Guid>? folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags);
        partial void ProcessMemoUpdateMemoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoUpdateMemoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateMemo.
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
        /// <param name="folderIds"></param>
        /// <param name="resources"></param>
        /// <param name="excerpts"></param>
        /// <param name="descriptors"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MemoAndLinks> MemoUpdateMemoAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid id = default,
            global::System.Guid projectId = default,
            string? title = default,
            global::System.Guid createdUserId = default,
            global::System.Guid lastEditUserId = default,
            global::System.DateTime createStamp = default,
            global::System.DateTime lastEditStamp = default,
            global::System.Guid folderId = default,
            string? dataURI = default,
            global::System.Collections.Generic.IList<global::System.Guid>? folderIds = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors = default,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoUpdateMemoArguments(
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
                dataURI: ref dataURI,
                folderIds: folderIds,
                resources: resources,
                excerpts: excerpts,
                descriptors: descriptors,
                tags: tags);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/updatememo?ProjectIdKey={projectIdKey}&Id={id}&ProjectId={projectId}&Title={title}&CreatedUserId={createdUserId}&LastEditUserId={lastEditUserId}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&LastEditStamp={lastEditStamp:yyyy-MM-ddTHH:mm:ssZ}&FolderId={folderId}&DataURI={dataURI}&{string.Join("&", folderIds?.Select(static x => $"folderIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", resources?.Select(static x => $"resources={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", excerpts?.Select(static x => $"excerpts={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", descriptors?.Select(static x => $"descriptors={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", tags?.Select(static x => $"tags={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoUpdateMemoRequest(
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
                dataURI: dataURI,
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
            ProcessMemoUpdateMemoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoUpdateMemoResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MemoAndLinks?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}