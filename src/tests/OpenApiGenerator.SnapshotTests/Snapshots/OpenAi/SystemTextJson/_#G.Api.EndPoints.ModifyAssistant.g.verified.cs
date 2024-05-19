//HintName: G.Api.EndPoints.ModifyAssistant.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Modifies an assistant.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<AssistantObject> ModifyAssistantAsync(
            string assistantId,
            ModifyAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: $"/assistants/{assistantId}");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<AssistantObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Modifies an assistant.
        /// </summary>
        /// <param name="assistantId"></param>
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
        public async global::System.Threading.Tasks.Task<AssistantObject> ModifyAssistantAsync(
            string assistantId,
            object? model,
            string? name,
            string? description,
            string? instructions,
            global::System.Collections.Generic.IList<object?>? tools,
            ModifyAssistantRequestToolResources? toolResources,
            ModifyAssistantRequestMetadata? metadata,
            double? temperature,
            double? topP,
            AssistantsApiResponseFormatOption? responseFormat,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ModifyAssistantRequest
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

            return await ModifyAssistantAsync(
                assistantId: assistantId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}