//HintName: G.ProjectsClient.ProjectsMoveColumn.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsMoveColumnArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int columnId,
            global::G.ProjectsMoveColumnRequest request);
        partial void PrepareProjectsMoveColumnRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int columnId,
            global::G.ProjectsMoveColumnRequest request);
        partial void ProcessProjectsMoveColumnResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsMoveColumnResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Move a project column
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectsMoveColumnResponse> ProjectsMoveColumnAsync(
            int columnId,
            global::G.ProjectsMoveColumnRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProjectsMoveColumnArguments(
                httpClient: HttpClient,
                columnId: ref columnId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/projects/columns/{columnId}/moves",
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
            PrepareProjectsMoveColumnRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                columnId: columnId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectsMoveColumnResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessProjectsMoveColumnResponseContent(
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
                global::G.ProjectsMoveColumnResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Move a project column
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="position">
        /// The position of the column in a project. Can be one of: `first`, `last`, or `after:&lt;column_id&gt;` to place after the specified column.<br/>
        /// Example: last
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectsMoveColumnResponse> ProjectsMoveColumnAsync(
            int columnId,
            string position,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ProjectsMoveColumnRequest
            {
                Position = position,
            };

            return await ProjectsMoveColumnAsync(
                columnId: columnId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}