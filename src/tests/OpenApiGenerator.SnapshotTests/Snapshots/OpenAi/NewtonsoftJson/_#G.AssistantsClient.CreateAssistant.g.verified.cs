//HintName: G.AssistantsClient.CreateAssistant.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        partial void PrepareCreateAssistantArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateAssistantRequest request);
        partial void PrepareCreateAssistantRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateAssistantRequest request);
        partial void ProcessCreateAssistantResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAssistantResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an assistant with a model and instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AssistantObject> CreateAssistantAsync(
            global::G.CreateAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateAssistantArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/assistants", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateAssistantRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateAssistantResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateAssistantResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AssistantObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an assistant with a model and instructions.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AssistantObject> CreateAssistantAsync(
            global::System.AnyOf<string, global::G.CreateAssistantRequestModel> model,
            string? name = default,
            string? description = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::System.OneOf<global::G.AssistantToolsCode?, global::G.AssistantToolsFileSearch?, global::G.AssistantToolsFunction?>?>? tools = default,
            global::G.CreateAssistantRequestToolResources? toolResources = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            global::System.OneOf<global::G.CreateAssistantRequestResponseFormat?, global::G.AssistantsApiResponseFormat?>? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateAssistantRequest
            {
                Model = model,
                Name = name,
                Description = description,
                Instructions = instructions,
                Tools = tools,
                ToolResources = toolResources,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                ResponseFormat = responseFormat,
            };

            return await CreateAssistantAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}