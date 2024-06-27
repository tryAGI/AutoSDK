//HintName: G.ChatClient.UpdateUserChatColor.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        /// <summary>
        /// Updates the color used for the user’s name in chat.<br/>
        /// Updates the color used for the user’s name in chat.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:chat\_color** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="color"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateUserChatColorAsync(
            string userId,
            global::G.UpdateUserChatColorColor color,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var colorValue = color switch
            {
                global::G.UpdateUserChatColorColor.Blue => "blue",
                global::G.UpdateUserChatColorColor.BlueViolet => "blue_violet",
                global::G.UpdateUserChatColorColor.CadetBlue => "cadet_blue",
                global::G.UpdateUserChatColorColor.Chocolate => "chocolate",
                global::G.UpdateUserChatColorColor.Coral => "coral",
                global::G.UpdateUserChatColorColor.DodgerBlue => "dodger_blue",
                global::G.UpdateUserChatColorColor.Firebrick => "firebrick",
                global::G.UpdateUserChatColorColor.GoldenRod => "golden_rod",
                global::G.UpdateUserChatColorColor.Green => "green",
                global::G.UpdateUserChatColorColor.HotPink => "hot_pink",
                global::G.UpdateUserChatColorColor.OrangeRed => "orange_red",
                global::G.UpdateUserChatColorColor.Red => "red",
                global::G.UpdateUserChatColorColor.SeaGreen => "sea_green",
                global::G.UpdateUserChatColorColor.SpringGreen => "spring_green",
                global::G.UpdateUserChatColorColor.YellowGreen => "yellow_green",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/chat/color?user_id={userId}&color={colorValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}