//HintName: G.AdminClient.AdminMergeProjects.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminMergeProjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? project1Id,
            ref string? project2Id,
            ref string? newTitle,
            ref string? newDescription,
            ref string? creatorId,
            ref bool mergeCodes);
        partial void PrepareAdminMergeProjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? project1Id,
            string? project2Id,
            string? newTitle,
            string? newDescription,
            string? creatorId,
            bool mergeCodes);
        partial void ProcessAdminMergeProjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminMergeProjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.AdminMergeProjectsResponse> AdminMergeProjectsAsync(
            string? token,
            string? project1Id,
            string? project2Id,
            string? newTitle,
            string? newDescription,
            string? creatorId,
            bool mergeCodes,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminMergeProjectsArguments(
                httpClient: _httpClient,
                token: ref token,
                project1Id: ref project1Id,
                project2Id: ref project2Id,
                newTitle: ref newTitle,
                newDescription: ref newDescription,
                creatorId: ref creatorId,
                mergeCodes: ref mergeCodes);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/mergeprojects?project1Id={project1Id}&project2Id={project2Id}&newTitle={newTitle}&newDescription={newDescription}&creatorId={creatorId}&mergeCodes={mergeCodes}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminMergeProjectsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                project1Id: project1Id,
                project2Id: project2Id,
                newTitle: newTitle,
                newDescription: newDescription,
                creatorId: creatorId,
                mergeCodes: mergeCodes);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminMergeProjectsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminMergeProjectsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.AdminMergeProjectsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}