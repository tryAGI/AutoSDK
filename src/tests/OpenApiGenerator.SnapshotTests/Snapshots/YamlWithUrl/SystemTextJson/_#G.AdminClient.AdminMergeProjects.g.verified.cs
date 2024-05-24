//HintName: G.AdminClient.AdminMergeProjects.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        /// <summary>
        /// MergeProjects.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="project1Id"></param>
        /// <param name="project2Id"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="creatorId"></param>
        /// <param name="mergeCodes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AdminMergeProjectsAsync(
            string token,
            string project1Id,
            string project2Id,
            string newTitle,
            string newDescription,
            string creatorId,
            bool mergeCodes,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/admin/mergeprojects?project1Id={project1Id}&project2Id={project2Id}&newTitle={newTitle}&newDescription={newDescription}&creatorId={creatorId}&mergeCodes={mergeCodes}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}