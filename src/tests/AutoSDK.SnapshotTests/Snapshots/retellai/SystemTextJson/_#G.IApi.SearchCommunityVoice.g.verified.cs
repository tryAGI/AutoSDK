//HintName: G.IApi.SearchCommunityVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Search for community voices from voice providers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchCommunityVoiceResponse> SearchCommunityVoiceAsync(

            global::G.SearchCommunityVoiceRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for community voices from voice providers
        /// </summary>
        /// <param name="voiceProvider">
        /// Voice provider to search.
        /// </param>
        /// <param name="searchQuery">
        /// Search query to find voices by name, description, or ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchCommunityVoiceResponse> SearchCommunityVoiceAsync(
            string searchQuery,
            global::G.SearchCommunityVoiceRequestVoiceProvider? voiceProvider = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}