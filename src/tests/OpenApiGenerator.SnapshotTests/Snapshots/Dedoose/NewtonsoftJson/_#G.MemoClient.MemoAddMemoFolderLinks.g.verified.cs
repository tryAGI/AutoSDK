//HintName: G.MemoClient.MemoAddMemoFolderLinks.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoAddMemoFolderLinksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string memoId,
            global::System.Collections.Generic.IList<string> folderIds);
        partial void PrepareMemoAddMemoFolderLinksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string memoId,
            global::System.Collections.Generic.IList<string> folderIds);
        partial void ProcessMemoAddMemoFolderLinksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoAddMemoFolderLinksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddMemoFolderLinks.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="folderIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> MemoAddMemoFolderLinksAsync(
            string token,
            string projectId,
            string memoId,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoAddMemoFolderLinksArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                memoId: ref memoId,
                folderIds: folderIds);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/addmemofolderlinks?projectId={projectId}&memoId={memoId}&{string.Join("&", folderIds.Select(static x => $"folderIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoAddMemoFolderLinksRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                memoId: memoId,
                folderIds: folderIds);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoAddMemoFolderLinksResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoAddMemoFolderLinksResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}