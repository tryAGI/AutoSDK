//HintName: G.ExcerptClient.ExcerptAddPDFSwfImageExcerpt.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptAddPDFSwfImageExcerptArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string userId,
            ref string resourceId,
            ref int start,
            ref int end,
            global::System.Collections.Generic.IList<string> tagIdsToApply);
        partial void PrepareExcerptAddPDFSwfImageExcerptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string userId,
            string resourceId,
            int start,
            int end,
            global::System.Collections.Generic.IList<string> tagIdsToApply);
        partial void ProcessExcerptAddPDFSwfImageExcerptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptAddPDFSwfImageExcerptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddPDFSwfImageExcerpt.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> ExcerptAddPDFSwfImageExcerptAsync(
            string token,
            string projectId,
            string userId,
            string resourceId,
            int start,
            int end,
            global::System.Collections.Generic.IList<string> tagIdsToApply,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptAddPDFSwfImageExcerptArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                start: ref start,
                end: ref end,
                tagIdsToApply: tagIdsToApply);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/excerpt/addpdfswfimageexcerpt?projectId={projectId}&userId={userId}&resourceId={resourceId}&start={start}&end={end}&{string.Join("&", tagIdsToApply.Select(static x => $"tagIdsToApply={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExcerptAddPDFSwfImageExcerptRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                start: start,
                end: end,
                tagIdsToApply: tagIdsToApply);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptAddPDFSwfImageExcerptResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptAddPDFSwfImageExcerptResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExcerptWithTagApps?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}