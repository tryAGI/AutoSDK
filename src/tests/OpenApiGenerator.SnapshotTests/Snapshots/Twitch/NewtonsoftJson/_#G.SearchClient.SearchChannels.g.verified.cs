//HintName: G.SearchClient.SearchChannels.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        partial void PrepareSearchChannelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string query,
            ref bool liveOnly,
            ref int first,
            ref string? after);
        partial void PrepareSearchChannelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string query,
            bool liveOnly,
            int first,
            string? after);
        partial void ProcessSearchChannelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchChannelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the channels that match the specified query and have streamed content within the past 6 months.<br/>
        /// Gets the channels that match the specified query and have streamed content within the past 6 months.<br/>
        /// The fields that the API uses for comparison depends on the value that the _live\_only_ query parameter is set to. If _live\_only_ is **false**, the API matches on the broadcaster’s login name. However, if _live\_only_ is **true**, the API matches on the broadcaster’s name and category name.<br/>
        /// To match, the beginning of the broadcaster’s name or category must match the query string. The comparison is case insensitive. If the query string is angel\_of\_death, it matches all names that begin with angel\_of\_death. However, if the query string is a phrase like _angel of death_, it matches to names starting with angelofdeath or names starting with angel\_of\_death.<br/>
        /// By default, the results include both live and offline channels. To get only live channels set the _live\_only_ query parameter to **true**.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="liveOnly"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchChannelsResponse> SearchChannelsAsync(
            string query,
            bool liveOnly,
            int first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSearchChannelsArguments(
                httpClient: _httpClient,
                query: ref query,
                liveOnly: ref liveOnly,
                first: ref first,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/search/channels?query={query}&live_only={liveOnly}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchChannelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                query: query,
                liveOnly: liveOnly,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchChannelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchChannelsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SearchChannelsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}