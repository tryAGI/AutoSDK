//HintName: G.AssistantsClient.CreateRun.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> CreateRunAsync(
            string threadId,
            CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/threads/{threadId}/runs", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<RunObject?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="assistantId"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="additionalInstructions"></param>
        /// <param name="additionalMessages"></param>
        /// <param name="tools"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="stream"></param>
        /// <param name="maxPromptTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> CreateRunAsync(
            string threadId,
            string assistantId,
            global::System.AnyOf<string?, CreateRunRequestModel?>? model = default,
            string? instructions = default,
            string? additionalInstructions = default,
            global::System.Collections.Generic.IList<CreateMessageRequest>? additionalMessages = default,
            global::System.Collections.Generic.IList<global::System.OneOf<AssistantToolsCode?, AssistantToolsFileSearch?, AssistantToolsFunction?>>? tools = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            TruncationObject? truncationStrategy = default,
            global::System.OneOf<CreateRunRequestToolChoice?, AssistantsNamedToolChoice?> toolChoice = default,
            global::System.OneOf<CreateRunRequestResponseFormat?, AssistantsApiResponseFormat?> responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateRunRequest
            {
                AssistantId = assistantId,
                Model = model,
                Instructions = instructions,
                AdditionalInstructions = additionalInstructions,
                AdditionalMessages = additionalMessages,
                Tools = tools,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                Stream = stream,
                MaxPromptTokens = maxPromptTokens,
                MaxCompletionTokens = maxCompletionTokens,
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ResponseFormat = responseFormat,
            };

            return await CreateRunAsync(
                threadId: threadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}