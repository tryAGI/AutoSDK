//HintName: G.IModerationClient.GetBlockedTerms.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Gets the broadcaster’s list of non-private, blocked words or phrases.<br/>
        /// Gets the broadcaster’s list of non-private, blocked words or phrases. These are the terms that the broadcaster or moderator added manually or that were denied by AutoMod.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:blocked\_terms** or **moderator:manage:blocked\_terms** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetBlockedTermsResponse> GetBlockedTermsAsync(
            string broadcasterId,
            string moderatorId,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}