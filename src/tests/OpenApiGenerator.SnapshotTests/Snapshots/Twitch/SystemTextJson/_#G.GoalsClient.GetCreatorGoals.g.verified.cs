//HintName: G.GoalsClient.GetCreatorGoals.g.cs

#nullable enable

namespace G
{
    public partial class GoalsClient
    {
        /// <summary>
        /// Gets the broadcaster’s list of active goals.<br/>
        /// Gets the broadcaster’s list of active goals. Use this endpoint to get the current progress of each goal.<br/>
        /// Instead of polling for the progress of a goal, consider [subscribing](https://dev.twitch.tv/docs/eventsub/manage-subscriptions) to receive notifications when a goal makes progress using the [channel.goal.progress](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelgoalprogress) subscription type. [Read More](https://dev.twitch.tv/docs/api/goals#requesting-event-notifications)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:goals** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetCreatorGoalsResponse> GetCreatorGoalsAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/goals?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetCreatorGoalsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}