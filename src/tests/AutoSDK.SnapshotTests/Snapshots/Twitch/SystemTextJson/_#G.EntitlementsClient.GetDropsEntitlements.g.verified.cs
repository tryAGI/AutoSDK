//HintName: G.EntitlementsClient.GetDropsEntitlements.g.cs

#nullable enable

namespace G
{
    public partial class EntitlementsClient
    {
        partial void PrepareGetDropsEntitlementsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? id,
            ref string? userId,
            ref string? gameId,
            ref global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus,
            ref string? after,
            ref int? first);
        partial void PrepareGetDropsEntitlementsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? id,
            string? userId,
            string? gameId,
            global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus,
            string? after,
            int? first);
        partial void ProcessGetDropsEntitlementsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDropsEntitlementsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets an organization’s list of entitlements that have been granted to a game, a user, or both.<br/>
        /// Gets an organization’s list of entitlements that have been granted to a game, a user, or both.<br/>
        /// **NOTE:** Entitlements returned in the response body data are not guaranteed to be sorted by any field returned by the API. To retrieve **CLAIMED** or **FULFILLED** entitlements, use the `fulfillment_status` query parameter to filter results. To retrieve entitlements for a specific game, use the `game_id` query parameter to filter results.<br/>
        /// The following table identifies the request parameters that you may specify based on the type of access token used.<br/>
        /// | Access token type | Parameter | Description |<br/>
        /// | - | - | - |<br/>
        /// | App | None | If you don’t specify request parameters, the request returns all entitlements that your organization owns. |<br/>
        /// | App | user_id | The request returns all entitlements for any game that the organization granted to the specified user. |<br/>
        /// | App | user_id, game_id | The request returns all entitlements that the specified game granted to the specified user. |<br/>
        /// | App | game_id | The request returns all entitlements that the specified game granted to all entitled users. |<br/>
        /// | User | None | If you don’t specify request parameters, the request returns all entitlements for any game that the organization granted to the user identified in the access token. |<br/>
        /// | User | user_id | Invalid. |<br/>
        /// | User | user_id, game_id | Invalid. |<br/>
        /// | User | game_id | The request returns all entitlements that the specified game granted to the user identified in the access token. |<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens). The client ID in the access token must own the game.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="gameId"></param>
        /// <param name="fulfillmentStatus"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetDropsEntitlementsResponse> GetDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? userId = default,
            string? gameId = default,
            global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus = default,
            string? after = default,
            int? first = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDropsEntitlementsArguments(
                httpClient: _httpClient,
                id: id,
                userId: ref userId,
                gameId: ref gameId,
                fulfillmentStatus: ref fulfillmentStatus,
                after: ref after,
                first: ref first);

            var __pathBuilder = new PathBuilder(
                path: "/entitlements/drops",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, delimiter: ",", explode: true) 
                .AddOptionalParameter("user_id", userId) 
                .AddOptionalParameter("game_id", gameId) 
                .AddOptionalParameter("fulfillment_status", fulfillmentStatus?.ToValueString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("first", first?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDropsEntitlementsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                userId: userId,
                gameId: gameId,
                fulfillmentStatus: fulfillmentStatus,
                after: after,
                first: first);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDropsEntitlementsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDropsEntitlementsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetDropsEntitlementsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}