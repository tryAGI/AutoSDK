//HintName: G.ProjectsClient.ProjectsUpdateCard.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsUpdateCardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int cardId,
            global::G.ProjectsUpdateCardRequest request);
        partial void PrepareProjectsUpdateCardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int cardId,
            global::G.ProjectsUpdateCardRequest request);
        partial void ProcessProjectsUpdateCardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsUpdateCardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            global::G.ProjectsUpdateCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareProjectsUpdateCardArguments(
                httpClient: _httpClient,
                cardId: ref cardId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/projects/columns/cards/{cardId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectsUpdateCardRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                cardId: cardId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectsUpdateCardResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectsUpdateCardResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ProjectCard?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="note">
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </param>
        /// <param name="archived">
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            string? note = default,
            bool archived = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ProjectsUpdateCardRequest
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