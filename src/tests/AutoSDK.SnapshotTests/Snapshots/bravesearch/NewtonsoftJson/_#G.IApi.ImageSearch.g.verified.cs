//HintName: G.IApi.ImageSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Image Search<br/>
        /// Search for images using Brave Search.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="count">
        /// Default Value: 50
        /// </param>
        /// <param name="safesearch">
        /// Default Value: moderate
        /// </param>
        /// <param name="spellcheck">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageSearchResponse> ImageSearchAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            int? count = default,
            global::G.ImageSearchSafesearch? safesearch = default,
            bool? spellcheck = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}