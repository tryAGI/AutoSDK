//HintName: G.ExcerptClient.ExcerptAddPDFSwfTextExcerpt.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
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
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/api/v1/excerpt/addpdfswftextexcerpt?projectId={projectId}&userId={userId}&resourceId={resourceId}&pageIndex={pageIndex}&start={start}&end={end}&text={text}&{string.Join("&", tagApps.Select(static x => $"tagApps={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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