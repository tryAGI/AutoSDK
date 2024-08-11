//HintName: G.MemoClient.MemoLinkFoldersToMemos.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoLinkFoldersToMemosArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            global::System.Collections.Generic.IList<string>? folderIds,
            global::System.Collections.Generic.IList<string>? memoIds);
        partial void PrepareMemoLinkFoldersToMemosRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            global::System.Collections.Generic.IList<string>? folderIds,
            global::System.Collections.Generic.IList<string>? memoIds);
        partial void ProcessMemoLinkFoldersToMemosResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoLinkFoldersToMemosResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// LinkFoldersToMemos.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="folderIds"></param>
        /// <param name="memoIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MemoLinkFoldersToMemosResponse> MemoLinkFoldersToMemosAsync(
            string? token,
            string? projectId,
            global::System.Collections.Generic.IList<string>? folderIds,
            global::System.Collections.Generic.IList<string>? memoIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoLinkFoldersToMemosArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                folderIds: folderIds,
                memoIds: memoIds);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/linkfolderstomemos?projectId={projectId}&{string.Join("&", folderIds?.Select(static x => $"folderIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", memoIds?.Select(static x => $"memoIds={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoLinkFoldersToMemosRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                folderIds: folderIds,
                memoIds: memoIds);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoLinkFoldersToMemosResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoLinkFoldersToMemosResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.MemoLinkFoldersToMemosResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}