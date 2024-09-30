//HintName: G.ModelsClient.GetModel.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {
        partial void PrepareGetModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string model,
            ref string? xClientName);
        partial void PrepareGetModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string model,
            string? xClientName);
        partial void ProcessGetModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a Model<br/>
        /// Returns the details of a model, provided its name.
        /// </summary>
        /// <param name="model">
        /// Example: command-r
        /// </param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetModelResponse> GetModelAsync(
            string model,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetModelArguments(
                httpClient: _httpClient,
                model: ref model,
                xClientName: ref xClientName);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/models/{model}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xClientName != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetModelRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                model: model,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetModelResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetModelResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetModelResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}