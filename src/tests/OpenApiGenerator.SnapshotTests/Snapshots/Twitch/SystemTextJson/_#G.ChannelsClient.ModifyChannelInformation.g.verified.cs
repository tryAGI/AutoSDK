//HintName: G.ChannelsClient.ModifyChannelInformation.g.cs

#nullable enable

namespace G
{
    public partial class ChannelsClient
    {
        /// <summary>
        /// Updates a channel’s properties.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ModifyChannelInformationAsync(
            string broadcasterId,
            ModifyChannelInformationBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/channels?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates a channel’s properties.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="gameId"></param>
        /// <param name="broadcasterLanguage"></param>
        /// <param name="title"></param>
        /// <param name="delay"></param>
        /// <param name="tags"></param>
        /// <param name="contentClassificationLabels"></param>
        /// <param name="isBrandedContent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ModifyChannelInformationAsync(
            string broadcasterId,
            string? gameId = default,
            string? broadcasterLanguage = default,
            string? title = default,
            int delay = default,
            global::System.Collections.Generic.IList<string?>? tags = default,
            global::System.Collections.Generic.IList<ModifyChannelInformationBodyContentClassificationLabels?>? contentClassificationLabels = default,
            bool isBrandedContent = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ModifyChannelInformationBody
            {
                GameId = gameId,
                BroadcasterLanguage = broadcasterLanguage,
                Title = title,
                Delay = delay,
                Tags = tags,
                ContentClassificationLabels = contentClassificationLabels,
                IsBrandedContent = isBrandedContent,
            };

            await ModifyChannelInformationAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}