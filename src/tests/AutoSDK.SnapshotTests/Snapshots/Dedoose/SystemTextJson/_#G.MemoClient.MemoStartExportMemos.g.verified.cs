//HintName: G.MemoClient.MemoStartExportMemos.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        partial void PrepareMemoStartExportMemosArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds,
            ref string? description,
            ref string? extension,
            ref bool? includeCodes,
            ref bool? includeMedia,
            ref bool? includeExcerpts,
            ref bool? includeDescriptors,
            ref string? symKey);
        partial void PrepareMemoStartExportMemosRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds,
            string? description,
            string? extension,
            bool? includeCodes,
            bool? includeMedia,
            bool? includeExcerpts,
            bool? includeDescriptors,
            string? symKey);
        partial void ProcessMemoStartExportMemosResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoStartExportMemosResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExportMemos.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="description"></param>
        /// <param name="extension"></param>
        /// <param name="includeCodes"></param>
        /// <param name="includeMedia"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="includeDescriptors"></param>
        /// <param name="symKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> MemoStartExportMemosAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds = default,
            string? description = default,
            string? extension = default,
            bool? includeCodes = default,
            bool? includeMedia = default,
            bool? includeExcerpts = default,
            bool? includeDescriptors = default,
            string? symKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareMemoStartExportMemosArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                memoIds: memoIds,
                description: ref description,
                extension: ref extension,
                includeCodes: ref includeCodes,
                includeMedia: ref includeMedia,
                includeExcerpts: ref includeExcerpts,
                includeDescriptors: ref includeDescriptors,
                symKey: ref symKey);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/startexportmemos?projectId={projectId}&{string.Join("&", memoIds?.Select(static x => $"memoIds={x}") ?? global::System.Array.Empty<string>())}&description={description}&extension={extension}&includeCodes={includeCodes}&includeMedia={includeMedia}&includeExcerpts={includeExcerpts}&includeDescriptors={includeDescriptors}&symKey={symKey}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMemoStartExportMemosRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                memoIds: memoIds,
                description: description,
                extension: extension,
                includeCodes: includeCodes,
                includeMedia: includeMedia,
                includeExcerpts: includeExcerpts,
                includeDescriptors: includeDescriptors,
                symKey: symKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMemoStartExportMemosResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMemoStartExportMemosResponseContent(
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

            return __content;
        }
    }
}