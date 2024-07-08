//HintName: G.ExcerptClient.ExcerptAddPDFSwfTextExcerpt.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptAddPDFSwfTextExcerptArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string userId,
            ref string resourceId,
            ref int pageIndex,
            ref int start,
            ref int end,
            ref string text,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps);
        partial void PrepareExcerptAddPDFSwfTextExcerptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string userId,
            string resourceId,
            int pageIndex,
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps);
        partial void ProcessExcerptAddPDFSwfTextExcerptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptAddPDFSwfTextExcerptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddPDFSwfTextExcerpt.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="text"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> ExcerptAddPDFSwfTextExcerptAsync(
            string token,
            string projectId,
            string userId,
            string resourceId,
            int pageIndex,
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptAddPDFSwfTextExcerptArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                pageIndex: ref pageIndex,
                start: ref start,
                end: ref end,
                text: ref text,
                tagApps: tagApps);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/excerpt/addpdfswftextexcerpt?projectId={projectId}&userId={userId}&resourceId={resourceId}&pageIndex={pageIndex}&start={start}&end={end}&text={text}&{string.Join("&", tagApps.Select(static x => $"tagApps={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExcerptAddPDFSwfTextExcerptRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                pageIndex: pageIndex,
                start: start,
                end: end,
                text: text,
                tagApps: tagApps);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptAddPDFSwfTextExcerptResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptAddPDFSwfTextExcerptResponseContent(
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