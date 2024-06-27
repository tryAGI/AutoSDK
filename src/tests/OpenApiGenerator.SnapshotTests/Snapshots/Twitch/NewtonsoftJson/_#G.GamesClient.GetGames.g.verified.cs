//HintName: G.GamesClient.GetGames.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class GamesClient
    {
        /// <summary>
        /// Gets information about specified games.<br/>
        /// Gets information about specified categories or games.<br/>
        /// You may get up to 100 categories or games by specifying their ID or name. You may specify all IDs, all names, or a combination of IDs and names. If you specify a combination of IDs and names, the total number of IDs and names must not exceed 100.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="igdbId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetGamesResponse> GetGamesAsync(
            global::System.Collections.Generic.IList<string> id,
            global::System.Collections.Generic.IList<string> name,
            global::System.Collections.Generic.IList<string> igdbId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/games?{string.Join("&", id.Select(static x => $"id={x}"))}&{string.Join("&", name.Select(static x => $"name={x}"))}&{string.Join("&", igdbId.Select(static x => $"igdbId={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetGamesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}