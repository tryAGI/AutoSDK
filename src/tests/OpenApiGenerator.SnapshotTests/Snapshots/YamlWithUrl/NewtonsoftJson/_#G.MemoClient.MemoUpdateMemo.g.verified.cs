//HintName: G.MemoClient.MemoUpdateMemo.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
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
        public async global::System.Threading.Tasks.Task<MemoAndLinks> MemoUpdateMemoAsync(
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
            global::System.Collections.Generic.IList<ObjectIdWithPos> resources,
            global::System.Collections.Generic.IList<ObjectIdWithPos> excerpts,
            global::System.Collections.Generic.IList<ObjectIdWithPos> descriptors,
            global::System.Collections.Generic.IList<ObjectIdWithPos> tags,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/memo/updatememo?ProjectIdKey={projectIdKey}&Id={id}&ProjectId={projectId}&Title={title}&CreatedUserId={createdUserId}&LastEditUserId={lastEditUserId}&CreateStamp={createStamp}&LastEditStamp={lastEditStamp}&FolderId={folderId}&DataURI={dataURI}&{string.Join("&", folderIds.Select(static x => $"folderIds={x}"))}&{string.Join("&", resources.Select(static x => $"resources={x}"))}&{string.Join("&", excerpts.Select(static x => $"excerpts={x}"))}&{string.Join("&", descriptors.Select(static x => $"descriptors={x}"))}&{string.Join("&", tags.Select(static x => $"tags={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<MemoAndLinks>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}