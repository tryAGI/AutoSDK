//HintName: G.MemoClient.MemoUpdateMemo.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoUpdateMemoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectIdKey,
            ref string id,
            ref string projectId,
            ref string title,
            ref string createdUserId,
            ref string lastEditUserId,
            global::System.DateTime createStamp,
            global::System.DateTime lastEditStamp,
            ref string folderId,
            ref string dataURI,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> tags);
        partial void PrepareMemoUpdateMemoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectIdKey,
            string id,
            string projectId,
            string title,
            string createdUserId,
            string lastEditUserId,
            global::System.DateTime createStamp,
            global::System.DateTime lastEditStamp,
            string folderId,
            string dataURI,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> tags);
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
            string token,
            string projectIdKey,
            string id,
            string projectId,
            string title,
            string createdUserId,
            string lastEditUserId,
            global::System.DateTime createStamp,
            global::System.DateTime lastEditStamp,
            string folderId,
            string dataURI,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> tags,
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
                createStamp: createStamp,
                lastEditStamp: lastEditStamp,
                folderId: ref folderId,
                dataURI: ref dataURI,
                folderIds: folderIds,
                resources: resources,
                excerpts: excerpts,
                descriptors: descriptors,
                tags: tags);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/updatememo?ProjectIdKey={projectIdKey}&Id={id}&ProjectId={projectId}&Title={title}&CreatedUserId={createdUserId}&LastEditUserId={lastEditUserId}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&LastEditStamp={lastEditStamp:yyyy-MM-ddTHH:mm:ssZ}&FolderId={folderId}&DataURI={dataURI}&{string.Join("&", folderIds.Select(static x => $"folderIds={x}"))}&{string.Join("&", resources.Select(static x => $"resources={x}"))}&{string.Join("&", excerpts.Select(static x => $"excerpts={x}"))}&{string.Join("&", descriptors.Select(static x => $"descriptors={x}"))}&{string.Join("&", tags.Select(static x => $"tags={x}"))}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MemoAndLinks?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}