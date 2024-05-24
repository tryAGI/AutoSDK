//HintName: G.TagClient.TagAddExcerptTagApplications.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TagClient
    {
        /// <summary>
        /// AddExcerptTagApplications.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TagAddExcerptTagApplicationsAsync(
            string token,
            string userId,
            string projectId,
            string resourceId,
            string excerptId,
            global::System.Collections.Generic.IList<TagAppSimple> tagApps,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/tag/addexcerpttagapplications?userId={userId}&projectId={projectId}&resourceId={resourceId}&excerptId={excerptId}&{string.Join("&", tagApps.Select(static x => $"tagApps={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}