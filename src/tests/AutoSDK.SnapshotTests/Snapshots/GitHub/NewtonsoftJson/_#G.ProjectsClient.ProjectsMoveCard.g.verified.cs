//HintName: G.ProjectsClient.ProjectsMoveCard.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsMoveCardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int cardId,
            global::G.ProjectsMoveCardRequest request);
        partial void PrepareProjectsMoveCardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int cardId,
            global::G.ProjectsMoveCardRequest request);
        partial void ProcessProjectsMoveCardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsMoveCardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Move a project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectsMoveCardResponse> ProjectsMoveCardAsync(
            int cardId,
            global::G.ProjectsMoveCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProjectsMoveCardArguments(
                httpClient: HttpClient,
                cardId: ref cardId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/projects/columns/cards/{cardId}/moves",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareProjectsMoveCardRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cardId: cardId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectsMoveCardResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessProjectsMoveCardResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.ProjectsMoveCardResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Move a project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="position">
        /// The position of the card in a column. Can be one of: `top`, `bottom`, or `after:&lt;card_id&gt;` to place after the specified card.<br/>
        /// Example: bottom
        /// </param>
        /// <param name="columnId">
        /// The unique identifier of the column the card should be moved to<br/>
        /// Example: 42
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectsMoveCardResponse> ProjectsMoveCardAsync(
            int cardId,
            string position,
            int? columnId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ProjectsMoveCardRequest
            {
                Position = position,
                ColumnId = columnId,
            };

            return await ProjectsMoveCardAsync(
                cardId: cardId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}