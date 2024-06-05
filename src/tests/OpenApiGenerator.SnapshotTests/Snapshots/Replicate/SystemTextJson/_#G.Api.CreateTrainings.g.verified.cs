//HintName: G.Api.CreateTrainings.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a training
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTrainingsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            TrainingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/models/{modelOwner}/{modelName}/versions/{versionId}/trainings", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create a training
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="destination"></param>
        /// <param name="input"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEventsFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTrainingsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            string destination,
            object input,
            string? webhook = default,
            global::System.Collections.Generic.IList<TrainingRequestWebhookEventsFilter?>? webhookEventsFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new TrainingRequest
            {
                Destination = destination,
                Input = input,
                Webhook = webhook,
                WebhookEventsFilter = webhookEventsFilter,
            };

            await CreateTrainingsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}