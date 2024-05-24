//HintName: G.ExcerptClient.ExcerptStartDeleteExcerptsJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        /// <summary>
        /// StartDeleteExcerptsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ExcerptStartDeleteExcerptsJobAsync(
            string token,
            string currentProjectId,
            global::System.Collections.Generic.IList<string> excerptIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/excerpt/startdeleteexcerptsjob?currentProjectId={currentProjectId}&{string.Join("&", excerptIds.Select(static x => $"excerptIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}