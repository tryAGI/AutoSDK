//HintName: G.IApi.Suggest.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Suggest (Autocomplete)<br/>
        /// Get autocomplete suggestions for a partial search query.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="count">
        /// Default Value: 5
        /// </param>
        /// <param name="rich">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SuggestSearchResponse> SuggestAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            int? count = default,
            bool? rich = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}