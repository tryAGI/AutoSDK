//HintName: G.IApi.VideoSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Video Search<br/>
        /// Search for videos using Brave Search.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="count">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="safesearch">
        /// Default Value: moderate
        /// </param>
        /// <param name="freshness"></param>
        /// <param name="spellcheck">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoSearchResponse> VideoSearchAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            int? count = default,
            int? offset = default,
            global::G.VideoSearchSafesearch? safesearch = default,
            string? freshness = default,
            bool? spellcheck = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}