//HintName: G.ChannelsClient.ModifyChannelInformation.g.cs

#nullable enable

namespace G
{
    public partial class ChannelsClient
    {
        partial void PrepareModifyChannelInformationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.ModifyChannelInformationBody request);
        partial void PrepareModifyChannelInformationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.ModifyChannelInformationBody request);
        partial void ProcessModifyChannelInformationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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

            PrepareArguments(
                client: _httpClient);
            PrepareModifyChannelInformationArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/channels",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareModifyChannelInformationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessModifyChannelInformationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
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
        /// <param name="gameId">
        /// The ID of the game that the user plays. The game is not updated if the ID isn’t a game ID that Twitch recognizes. To unset this field, use “0” or “” (an empty string).
        /// </param>
        /// <param name="broadcasterLanguage">
        /// The user’s preferred language. Set the value to an ISO 639-1 two-letter language code (for example, _en_ for English). Set to “other” if the user’s preferred language is not a Twitch supported language. The language isn’t updated if the language code isn’t a Twitch supported language.
        /// </param>
        /// <param name="title">
        /// The title of the user’s stream. You may not set this field to an empty string.
        /// </param>
        /// <param name="delay">
        /// The number of seconds you want your broadcast buffered before streaming it live. The delay helps ensure fairness during competitive play. Only users with Partner status may set this field. The maximum delay is 900 seconds (15 minutes).
        /// </param>
        /// <param name="tags">
        /// A list of channel-defined tags to apply to the channel. To remove all tags from the channel, set tags to an empty array. Tags help identify the content that the channel streams. [Learn More](https://help.twitch.tv/s/article/guide-to-tags)  <br/>
        ///   <br/>
        /// A channel may specify a maximum of 10 tags. Each tag is limited to a maximum of 25 characters and may not be an empty string or contain spaces or special characters. Tags are case insensitive. For readability, consider using camelCasing or PascalCasing.
        /// </param>
        /// <param name="contentClassificationLabels">
        /// List of labels that should be set as the Channel’s CCLs.
        /// </param>
        /// <param name="isBrandedContent">
        /// Boolean flag indicating if the channel has branded content.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ModifyChannelInformationAsync(
            string broadcasterId,
            string? gameId = default,
            string? broadcasterLanguage = default,
            string? title = default,
            int? delay = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>? contentClassificationLabels = default,
            bool? isBrandedContent = default,
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