//HintName: G.IEntitlementsClient.GetDropsEntitlements.g.cs
#nullable enable

namespace G
{
    public partial interface IEntitlementsClient
    {
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
        global::System.Threading.Tasks.Task<global::G.GetDropsEntitlementsResponse> GetDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? userId = default,
            string? gameId = default,
            global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus = default,
            string? after = default,
            int first = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}