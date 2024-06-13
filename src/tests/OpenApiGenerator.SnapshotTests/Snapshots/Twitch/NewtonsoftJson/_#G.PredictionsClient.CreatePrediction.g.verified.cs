//HintName: G.PredictionsClient.CreatePrediction.g.cs

#nullable enable

namespace G
{
    public partial class PredictionsClient
    {
        /// <summary>
        /// Create a Channel Points Prediction.<br/>
        /// Creates a Channel Points Prediction.<br/>
        /// With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome. The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePredictionResponse> CreatePredictionAsync(
            global::G.CreatePredictionBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/predictions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreatePredictionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a Channel Points Prediction.<br/>
        /// Creates a Channel Points Prediction.<br/>
        /// With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome. The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="title"></param>
        /// <param name="outcomes"></param>
        /// <param name="predictionWindow"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePredictionResponse> CreatePredictionAsync(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcomes> outcomes,
            int predictionWindow,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreatePredictionBody
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