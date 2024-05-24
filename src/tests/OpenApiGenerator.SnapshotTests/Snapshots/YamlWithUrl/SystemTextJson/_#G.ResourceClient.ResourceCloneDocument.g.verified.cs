//HintName: G.ResourceClient.ResourceCloneDocument.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        /// <summary>
        /// CloneDocument.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cloneExcerpts"></param>
        /// <param name="cloneTagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ResourceServiceCloneDocumentControllerOutput> ResourceCloneDocumentAsync(
            string token,
            string projectId,
            string resourceId,
            bool cloneExcerpts,
            bool cloneTagApps,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/resource/clonedocument?projectId={projectId}&resourceId={resourceId}&cloneExcerpts={cloneExcerpts}&cloneTagApps={cloneTagApps}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ResourceServiceCloneDocumentControllerOutput>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}