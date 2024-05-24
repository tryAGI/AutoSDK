//HintName: G.ResourceClient.ResourceUpdateDocumentDataAndExcerpts.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        /// <summary>
        /// UpdateDocumentDataAndExcerpts.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="updatedTextDataURI"></param>
        /// <param name="updatedLength"></param>
        /// <param name="excerpts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ResourceUpdateDocumentDataAndExcerptsAsync(
            string token,
            string projectId,
            string userId,
            string resourceId,
            string updatedTextDataURI,
            int updatedLength,
            global::System.Collections.Generic.IList<Excerpt> excerpts,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/resource/updatedocumentdataandexcerpts?projectId={projectId}&userId={userId}&resourceId={resourceId}&updatedTextDataURI={updatedTextDataURI}&updatedLength={updatedLength}&{string.Join("&", excerpts.Select(static x => $"excerpts={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}