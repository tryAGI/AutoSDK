//HintName: G.MemoClient.MemoUnlinkObject.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoUnlinkObjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string memoId,
            ref string resourceId,
            ref string excerptId,
            ref string descriptorId,
            ref string tagId);
        partial void PrepareMemoUnlinkObjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string memoId,
            string resourceId,
            string excerptId,
            string descriptorId,
            string tagId);
        partial void ProcessMemoUnlinkObjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoUnlinkObjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UnlinkObject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> MemoUnlinkObjectAsync(
            string token,
            string projectId,
            string memoId,
            string resourceId,
            string excerptId,
            string descriptorId,
            string tagId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoUnlinkObjectArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                memoId: ref memoId,
                resourceId: ref resourceId,
                excerptId: ref excerptId,
                descriptorId: ref descriptorId,
                tagId: ref tagId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/unlinkobject?projectId={projectId}&memoId={memoId}&resourceId={resourceId}&excerptId={excerptId}&descriptorId={descriptorId}&tagId={tagId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoUnlinkObjectRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                memoId: memoId,
                resourceId: resourceId,
                excerptId: excerptId,
                descriptorId: descriptorId,
                tagId: tagId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoUnlinkObjectResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoUnlinkObjectResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}