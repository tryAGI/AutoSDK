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
                client: _httpClient);
            PrepareProjectsMoveColumnArguments(
                httpClient: _httpClient,
                columnId: ref columnId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/projects/columns/{columnId}/moves", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectsMoveColumnRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                columnId: columnId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectsMoveColumnResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectsMoveColumnResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ProjectsMoveColumnResponse?>(__content, _jsonSerializerOptions) ??
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
            var request = new global::G.ProjectsMoveColumnRequest
            {
                Position = position,
            };

            return await ProjectsMoveColumnAsync(
                columnId: columnId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}