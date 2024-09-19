//HintName: G.GamesClient.GetGames.g.cs

#nullable enable

namespace G
{
    public partial class GamesClient
    {
        partial void PrepareGetGamesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? id,
            global::System.Collections.Generic.IList<string>? name,
            global::System.Collections.Generic.IList<string>? igdbId);
        partial void PrepareGetGamesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? id,
            global::System.Collections.Generic.IList<string>? name,
            global::System.Collections.Generic.IList<string>? igdbId);
        partial void ProcessGetGamesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetGamesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? name = default,
            global::System.Collections.Generic.IList<string>? igdbId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetGamesArguments(
                httpClient: _httpClient,
                id: id,
                name: name,
                igdbId: igdbId);

            var __pathBuilder = new PathBuilder(
                path: "/games",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, delimiter: ",", explode: true) 
                .AddOptionalParameter("name", name, delimiter: ",", explode: true) 
                .AddOptionalParameter("igdb_id", igdbId, delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetGamesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                name: name,
                igdbId: igdbId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetGamesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetGamesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetGamesResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}