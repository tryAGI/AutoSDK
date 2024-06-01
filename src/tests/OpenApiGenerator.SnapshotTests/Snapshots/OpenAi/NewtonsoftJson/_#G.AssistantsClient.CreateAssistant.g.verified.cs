//HintName: G.AssistantsClient.CreateAssistant.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        /// <summary>
        /// Create an assistant with a model and instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<AssistantObject> CreateAssistantAsync(
            CreateAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/assistants", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<AssistantObject?>(__content) ??
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
        public async global::System.Threading.Tasks.Task<AssistantObject> CreateAssistantAsync(
            global::System.AnyOf<string, CreateAssistantRequestModel> model,
            string? name = default,
            string? description = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::System.OneOf<AssistantToolsCode?, AssistantToolsFileSearch?, AssistantToolsFunction?>>? tools = default,
            CreateAssistantRequestToolResources? toolResources = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            global::System.OneOf<CreateAssistantRequestResponseFormat?, AssistantsApiResponseFormat?> responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateAssistantRequest
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