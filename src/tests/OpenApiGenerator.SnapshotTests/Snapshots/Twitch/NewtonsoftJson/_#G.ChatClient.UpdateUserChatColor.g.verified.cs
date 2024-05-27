//HintName: G.ChatClient.UpdateUserChatColor.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        /// <summary>
        /// Updates the color used for the user’s name in chat.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="color"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateUserChatColorAsync(
            string userId,
            UpdateUserChatColorColor color,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var colorValue = color switch
            {
                UpdateUserChatColorColor.Blue => "blue",
                UpdateUserChatColorColor.BlueViolet => "blue_violet",
                UpdateUserChatColorColor.CadetBlue => "cadet_blue",
                UpdateUserChatColorColor.Chocolate => "chocolate",
                UpdateUserChatColorColor.Coral => "coral",
                UpdateUserChatColorColor.DodgerBlue => "dodger_blue",
                UpdateUserChatColorColor.Firebrick => "firebrick",
                UpdateUserChatColorColor.GoldenRod => "golden_rod",
                UpdateUserChatColorColor.Green => "green",
                UpdateUserChatColorColor.HotPink => "hot_pink",
                UpdateUserChatColorColor.OrangeRed => "orange_red",
                UpdateUserChatColorColor.Red => "red",
                UpdateUserChatColorColor.SeaGreen => "sea_green",
                UpdateUserChatColorColor.SpringGreen => "spring_green",
                UpdateUserChatColorColor.YellowGreen => "yellow_green",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/chat/color?user_id={userId}&color={colorValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}