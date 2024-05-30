//HintName: G.SubscriptionsClient.GetBroadcasterSubscriptions.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class SubscriptionsClient
    {
        /// <summary>
        /// Gets a list of users that subscribe to the specified broadcaster.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetBroadcasterSubscriptionsResponse> GetBroadcasterSubscriptionsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string> userId,
            string first,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/subscriptions?broadcaster_id={broadcasterId}&{string.Join("&", userId.Select(static x => $"userId={x}"))}&first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetBroadcasterSubscriptionsResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }
    }
}