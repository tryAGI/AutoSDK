//HintName: G.PollsClient.CreatePoll.g.cs

#nullable enable

namespace G
{
    public partial class PollsClient
    {
        /// <summary>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreatePollResponse> CreatePollAsync(
            CreatePollBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/polls", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<CreatePollResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="title"></param>
        /// <param name="choices"></param>
        /// <param name="duration"></param>
        /// <param name="channelPointsVotingEnabled"></param>
        /// <param name="channelPointsPerVote"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreatePollResponse> CreatePollAsync(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<CreatePollBodyChoices> choices,
            int duration,
            bool channelPointsVotingEnabled = default,
            int channelPointsPerVote = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreatePollBody
            {
                BroadcasterId = broadcasterId,
                Title = title,
                Choices = choices,
                Duration = duration,
                ChannelPointsVotingEnabled = channelPointsVotingEnabled,
                ChannelPointsPerVote = channelPointsPerVote,
            };

            return await CreatePollAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}