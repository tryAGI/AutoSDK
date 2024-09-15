//HintName: G.ISearchClient.SearchChannels.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
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
        global::System.Threading.Tasks.Task<global::G.SearchChannelsResponse> SearchChannelsAsync(
            string query,
            bool liveOnly = default,
            int first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}