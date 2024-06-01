//HintName: G.ProjectsClient.ProjectsUpdateCard.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            ProjectsUpdateCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/projects/columns/cards/{cardId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ProjectCard?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="note"></param>
        /// <param name="archived"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            string? note = default,
            bool archived = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ProjectsUpdateCardRequest
            {
                Note = note,
                Archived = archived,
            };

            return await ProjectsUpdateCardAsync(
                cardId: cardId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}