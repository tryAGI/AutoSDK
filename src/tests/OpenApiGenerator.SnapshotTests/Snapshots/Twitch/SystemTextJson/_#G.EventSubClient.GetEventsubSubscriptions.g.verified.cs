//HintName: G.EventSubClient.GetEventsubSubscriptions.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        /// <summary>
        /// Gets a list of EventSub subscriptions that the client in the access token created.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetEventSubSubscriptionsResponse> GetEventsubSubscriptionsAsync(
            global::G.GetEventsubSubscriptionsStatus status,
            global::G.GetEventsubSubscriptionsType type,
            string userId,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/eventsub/subscriptions?status={status}&type={type}&user_id={userId}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetEventSubSubscriptionsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}