//HintName: G.EntitlementsClient.GetDropsEntitlements.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class EntitlementsClient
    {
        /// <summary>
        /// Gets an organization’s list of entitlements that have been granted to a game, a user, or both.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="gameId"></param>
        /// <param name="fulfillmentStatus"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetDropsEntitlementsResponse> GetDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string> id,
            string userId,
            string gameId,
            GetDropsEntitlementsFulfillmentStatus fulfillmentStatus,
            string after,
            int first,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/entitlements/drops?{string.Join("&", id.Select(static x => $"id={x}"))}&user_id={userId}&game_id={gameId}&fulfillment_status={fulfillmentStatus}&after={after}&first={first}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetDropsEntitlementsResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }
    }
}