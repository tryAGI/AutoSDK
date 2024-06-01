//HintName: G.PredictionsClient.CreatePrediction.g.cs

#nullable enable

namespace G
{
    public partial class PredictionsClient
    {
        /// <summary>
        /// Create a Channel Points Prediction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreatePredictionResponse> CreatePredictionAsync(
            CreatePredictionBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/predictions", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<CreatePredictionResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a Channel Points Prediction.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="title"></param>
        /// <param name="outcomes"></param>
        /// <param name="predictionWindow"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreatePredictionResponse> CreatePredictionAsync(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<CreatePredictionBodyOutcomes> outcomes,
            int predictionWindow,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreatePredictionBody
            {
                BroadcasterId = broadcasterId,
                Title = title,
                Outcomes = outcomes,
                PredictionWindow = predictionWindow,
            };

            return await CreatePredictionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}