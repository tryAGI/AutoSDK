//HintName: G.MemoClient.MemoLinkObject.g.cs

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoLinkObjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid projectId,
            ref global::System.Guid memoId,
            ref global::System.Guid id1,
            ref int position1,
            ref global::System.Guid id2,
            ref int position2,
            ref global::System.Guid id3,
            ref int position3,
            ref global::System.Guid id4,
            ref int position4);
        partial void PrepareMemoLinkObjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid projectId,
            global::System.Guid memoId,
            global::System.Guid id1,
            int position1,
            global::System.Guid id2,
            int position2,
            global::System.Guid id3,
            int position3,
            global::System.Guid id4,
            int position4);
        partial void ProcessMemoLinkObjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoLinkObjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// LinkObject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="id1"></param>
        /// <param name="position1"></param>
        /// <param name="id2"></param>
        /// <param name="position2"></param>
        /// <param name="id3"></param>
        /// <param name="position3"></param>
        /// <param name="id4"></param>
        /// <param name="position4"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MemoLinkObjectResponse> MemoLinkObjectAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid memoId = default,
            global::System.Guid id1 = default,
            int position1 = default,
            global::System.Guid id2 = default,
            int position2 = default,
            global::System.Guid id3 = default,
            int position3 = default,
            global::System.Guid id4 = default,
            int position4 = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoLinkObjectArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                memoId: ref memoId,
                id1: ref id1,
                position1: ref position1,
                id2: ref id2,
                position2: ref position2,
                id3: ref id3,
                position3: ref position3,
                id4: ref id4,
                position4: ref position4);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/linkobject?projectId={projectId}&memoId={memoId}&Id={id1}&Position={position1}&Id={id2}&Position={position2}&Id={id3}&Position={position3}&Id={id4}&Position={position4}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoLinkObjectRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                memoId: memoId,
                id1: id1,
                position1: position1,
                id2: id2,
                position2: position2,
                id3: id3,
                position3: position3,
                id4: id4,
                position4: position4);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoLinkObjectResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoLinkObjectResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MemoLinkObjectResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}