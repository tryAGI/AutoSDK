//HintName: G.TagClient.TagStartImportTagsJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TagClient
    {
        /// <summary>
        /// StartImportTagsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="tagVOs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TagStartImportTagsJobAsync(
            string token,
            string projectId,
            global::System.Collections.Generic.IList<TagImportVO> tagVOs,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/tag/startimporttagsjob?projectId={projectId}&{string.Join("&", tagVOs.Select(static x => $"tagVOs={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}