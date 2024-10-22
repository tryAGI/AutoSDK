//HintName: G.ChannelPointsClient.GetCustomRewardRedemption.g.cs

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        partial void PrepareGetCustomRewardRedemptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string rewardId,
            ref global::G.GetCustomRewardRedemptionStatus? status,
            global::System.Collections.Generic.IList<string>? id,
            ref global::G.GetCustomRewardRedemptionSort? sort,
            ref string? after,
            ref int? first);
        partial void PrepareGetCustomRewardRedemptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string rewardId,
            global::G.GetCustomRewardRedemptionStatus? status,
            global::System.Collections.Generic.IList<string>? id,
            global::G.GetCustomRewardRedemptionSort? sort,
            string? after,
            int? first);
        partial void ProcessGetCustomRewardRedemptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCustomRewardRedemptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of redemptions for a custom reward.<br/>
        /// Gets a list of redemptions for the specified custom reward. The app used to create the reward is the only app that may get the redemptions.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:redemptions** or **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="rewardId"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="sort"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetCustomRewardRedemptionResponse> GetCustomRewardRedemptionAsync(
            string broadcasterId,
            string rewardId,
            global::G.GetCustomRewardRedemptionStatus? status = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::G.GetCustomRewardRedemptionSort? sort = default,
            string? after = default,
            int? first = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetCustomRewardRedemptionArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                rewardId: ref rewardId,
                status: ref status,
                id: id,
                sort: ref sort,
                after: ref after,
                first: ref first);

            var __pathBuilder = new PathBuilder(
                path: "/channel_points/custom_rewards/redemptions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddRequiredParameter("reward_id", rewardId) 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("id", id, delimiter: ",", explode: true) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("first", first?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetCustomRewardRedemptionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                status: status,
                id: id,
                sort: sort,
                after: after,
                first: first);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetCustomRewardRedemptionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetCustomRewardRedemptionResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.GetCustomRewardRedemptionResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}