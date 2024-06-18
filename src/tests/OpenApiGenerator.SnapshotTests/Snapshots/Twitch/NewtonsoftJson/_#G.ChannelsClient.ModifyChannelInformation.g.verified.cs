//HintName: G.ChannelsClient.ModifyChannelInformation.g.cs

#nullable enable

namespace G
{
    public partial class ChannelsClient
    {
        /// <summary>
        /// Updates a channel’s properties.<br/>
        /// Updates a channel’s properties.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.<br/>
        /// __Request Body:__<br/>
        /// All fields are optional, but you must specify at least one field.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ModifyChannelInformationAsync(
            string broadcasterId,
            global::G.ModifyChannelInformationBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/channels?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates a channel’s properties.<br/>
        /// Updates a channel’s properties.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.<br/>
        /// __Request Body:__<br/>
        /// All fields are optional, but you must specify at least one field.
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
            global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabels?>? contentClassificationLabels = default,
            bool isBrandedContent = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ModifyChannelInformationBody
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