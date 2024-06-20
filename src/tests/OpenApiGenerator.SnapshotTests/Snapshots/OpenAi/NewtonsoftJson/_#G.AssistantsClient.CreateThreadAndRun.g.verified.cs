//HintName: G.AssistantsClient.CreateThreadAndRun.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        /// <summary>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunObject> CreateThreadAndRunAsync(
            global::G.CreateThreadAndRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/threads/runs", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RunObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="thread"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="stream"></param>
        /// <param name="maxPromptTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunObject> CreateThreadAndRunAsync(
            string assistantId,
            global::G.CreateThreadRequest? thread = default,
            global::System.AnyOf<string?, global::G.CreateThreadAndRunRequestModel?>? model = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::System.OneOf<global::G.AssistantToolsCode?, global::G.AssistantToolsFileSearch?, global::G.AssistantToolsFunction?>?>? tools = default,
            global::G.CreateThreadAndRunRequestToolResources? toolResources = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::G.TruncationObject? truncationStrategy = default,
            global::System.OneOf<global::G.CreateThreadAndRunRequestToolChoice?, global::G.AssistantsNamedToolChoice?>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::System.OneOf<global::G.CreateThreadAndRunRequestResponseFormat?, global::G.AssistantsApiResponseFormat?>? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateThreadAndRunRequest
            {
                AssistantId = assistantId,
                Thread = thread,
                Model = model,
                Instructions = instructions,
                Tools = tools,
                ToolResources = toolResources,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                Stream = stream,
                MaxPromptTokens = maxPromptTokens,
                MaxCompletionTokens = maxCompletionTokens,
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
            };

            return await CreateThreadAndRunAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}