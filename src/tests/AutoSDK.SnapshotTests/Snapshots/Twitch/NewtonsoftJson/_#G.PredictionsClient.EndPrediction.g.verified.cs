//HintName: G.PredictionsClient.EndPrediction.g.cs

#nullable enable

namespace G
{
    public partial class PredictionsClient
    {
        partial void PrepareEndPredictionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.EndPredictionBody request);
        partial void PrepareEndPredictionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.EndPredictionBody request);
        partial void ProcessEndPredictionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEndPredictionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EndPredictionResponse> EndPredictionAsync(
            global::G.EndPredictionBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareEndPredictionArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/predictions",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareEndPredictionRequest(
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
            ProcessEndPredictionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessEndPredictionResponseContent(
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
                global::G.EndPredictionResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="id">
        /// The ID of the prediction to update.
        /// </param>
        /// <param name="status">
        /// The status to set the prediction to. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.<br/>
        /// * CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.<br/>
        /// * LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.<br/>
        ///   <br/>
        /// The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  <br/>
        ///   <br/>
        /// The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.
        /// </param>
        /// <param name="winningOutcomeId">
        /// The ID of the winning outcome. You must set this parameter if you set `status` to RESOLVED.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EndPredictionResponse> EndPredictionAsync(
            string broadcasterId,
            string id,
            global::G.EndPredictionBodyStatus status,
            string? winningOutcomeId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.EndPredictionBody
            {
                BroadcasterId = broadcasterId,
                Id = id,
                Status = status,
                WinningOutcomeId = winningOutcomeId,
            };

            return await EndPredictionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}