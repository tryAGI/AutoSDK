//HintName: G.ITrackingClient.GetRequestSearchSuggestions.g.cs
#nullable enable

namespace G
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Search Request Suggestions
        /// </summary>
        /// <param name="field"></param>
        /// <param name="prefix"></param>
        /// <param name="metadataKey"></param>
        /// <param name="promptId"></param>
        /// <param name="filterGroup"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetRequestSearchSuggestionsResponse> GetRequestSearchSuggestionsAsync(
            global::G.GetRequestSearchSuggestionsField field,
            string? prefix = default,
            string? metadataKey = default,
            int? promptId = default,
            string? filterGroup = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}