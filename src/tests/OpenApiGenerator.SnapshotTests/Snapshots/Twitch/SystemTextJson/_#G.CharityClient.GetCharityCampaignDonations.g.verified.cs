//HintName: G.CharityClient.GetCharityCampaignDonations.g.cs

#nullable enable

namespace G
{
    public partial class CharityClient
    {
        partial void PrepareGetCharityCampaignDonationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref int first,
            ref string after);
        partial void PrepareGetCharityCampaignDonationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            int first,
            string after);
        partial void ProcessGetCharityCampaignDonationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessGetCharityCampaignDonationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the list of donations that users have made to the broadcaster’s active charity campaign.<br/>
        /// Gets the list of donations that users have made to the broadcaster’s active charity campaign.<br/>
        /// To receive events as donations occur, subscribe to the [channel.charity\_campaign.donate](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelcharity%5Fcampaigndonate) subscription type.<br/>
        /// __Authorization:__<br/>
        /// Requires a user access token that includes the **channel:read:charity** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetCharityCampaignDonationsResponse> GetCharityCampaignDonationsAsync(
            string broadcasterId,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/charity/donations?broadcaster_id={broadcasterId}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetCharityCampaignDonationsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}