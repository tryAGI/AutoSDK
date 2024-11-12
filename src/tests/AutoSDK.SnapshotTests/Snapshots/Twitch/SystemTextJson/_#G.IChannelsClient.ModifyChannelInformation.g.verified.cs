//HintName: G.IChannelsClient.ModifyChannelInformation.g.cs
#nullable enable

namespace G
{
    public partial interface IChannelsClient
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ModifyChannelInformationAsync(
            string broadcasterId,
            global::G.ModifyChannelInformationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task ModifyChannelInformationAsync(
            string broadcasterId,
            string? gameId = default,
            string? broadcasterLanguage = default,
            string? title = default,
            int? delay = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>? contentClassificationLabels = default,
            bool? isBrandedContent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}