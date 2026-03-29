//HintName: G.ITranslationsClient.GetTranslationsByRootVideoId.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Get video translations of a given root video id<br/>
        /// Returns the translation status for each language associated with the given studio video. Each entry has a `status` of `complete`, `in_progress`, or `error`. Active state takes priority: a re-triggered language appears as `in_progress`, not `complete`.
        /// </summary>
        /// <param name="rootVideoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetVideoTranslationsApiResponse> GetTranslationsByRootVideoIdAsync(
            global::System.Guid rootVideoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}