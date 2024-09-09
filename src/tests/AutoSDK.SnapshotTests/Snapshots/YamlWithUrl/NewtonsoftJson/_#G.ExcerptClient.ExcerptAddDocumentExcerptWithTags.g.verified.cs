//HintName: G.ExcerptClient.ExcerptAddDocumentExcerptWithTags.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        /// <summary>
        /// AddDocumentExcerptWithTags.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="excerptText"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ExcerptWithTagApps> ExcerptAddDocumentExcerptWithTagsAsync(
            string token,
            string projectId,
            string userId,
            string resourceId,
            string title,
            string description,
            int startIndex,
            int endIndex,
            string excerptText,
            global::System.Collections.Generic.IList<TagAppSimple> tagApps,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/excerpt/adddocumentexcerptwithtags?projectId={projectId}&userId={userId}&resourceId={resourceId}&title={title}&description={description}&startIndex={startIndex}&endIndex={endIndex}&excerptText={excerptText}&{string.Join("&", tagApps.Select(static x => $"tagApps={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ExcerptWithTagApps>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}