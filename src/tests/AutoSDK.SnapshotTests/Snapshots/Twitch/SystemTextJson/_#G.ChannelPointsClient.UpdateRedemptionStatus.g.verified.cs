//HintName: G.ChannelPointsClient.UpdateRedemptionStatus.g.cs

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        partial void PrepareUpdateRedemptionStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string> id,
            ref string broadcasterId,
            ref string rewardId,
            global::G.UpdateRedemptionStatusBody request);
        partial void PrepareUpdateRedemptionStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string> id,
            string broadcasterId,
            string rewardId,
            global::G.UpdateRedemptionStatusBody request);
        partial void ProcessUpdateRedemptionStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRedemptionStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a redemption’s status.<br/>
        /// Updates a redemption’s status. You may update a redemption only if its status is UNFULFILLED. The app used to create the reward is the only app that may update the redemption.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="rewardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateRedemptionStatusResponse> UpdateRedemptionStatusAsync(
            global::System.Collections.Generic.IList<string> id,
            string broadcasterId,
            string rewardId,
            global::G.UpdateRedemptionStatusBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRedemptionStatusArguments(
                httpClient: _httpClient,
                id: id,
                broadcasterId: ref broadcasterId,
                rewardId: ref rewardId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/channel_points/custom_rewards/redemptions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("id", id, delimiter: ",", explode: true) 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddRequiredParameter("reward_id", rewardId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRedemptionStatusRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateRedemptionStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRedemptionStatusResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateRedemptionStatusResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates a redemption’s status.<br/>
        /// Updates a redemption’s status. You may update a redemption only if its status is UNFULFILLED. The app used to create the reward is the only app that may update the redemption.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="rewardId"></param>
        /// <param name="status">
        /// The status to set the redemption to. Possible values are:  <br/>
        ///   <br/>
        /// * CANCELED<br/>
        /// * FULFILLED<br/>
        ///   <br/>
        /// Setting the status to CANCELED refunds the user’s channel points.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateRedemptionStatusResponse> UpdateRedemptionStatusAsync(
            global::System.Collections.Generic.IList<string> id,
            string broadcasterId,
            string rewardId,
            global::G.UpdateRedemptionStatusBodyStatus status,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateRedemptionStatusBody
            {
                Status = status,
            };

            return await UpdateRedemptionStatusAsync(
                id: id,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}