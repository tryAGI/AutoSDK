//HintName: G.IApi.Autocomplete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Autocomplete<br/>
        /// Get Google autocomplete suggestions for a partial query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutocompleteResponse> AutocompleteAsync(

            global::G.AutocompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Autocomplete<br/>
        /// Get Google autocomplete suggestions for a partial query.
        /// </summary>
        /// <param name="q">
        /// Partial query string for autocomplete suggestions.<br/>
        /// Example: apple
        /// </param>
        /// <param name="gl">
        /// Country code for localized suggestions (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </param>
        /// <param name="hl">
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutocompleteResponse> AutocompleteAsync(
            string q,
            string? gl = default,
            string? hl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}