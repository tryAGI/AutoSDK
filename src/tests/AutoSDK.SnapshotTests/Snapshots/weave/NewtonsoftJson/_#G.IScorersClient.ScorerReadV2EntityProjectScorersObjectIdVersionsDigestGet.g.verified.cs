//HintName: G.IScorersClient.ScorerReadV2EntityProjectScorersObjectIdVersionsDigestGet.g.cs
#nullable enable

namespace G
{
    public partial interface IScorersClient
    {
        /// <summary>
        /// Scorer Read<br/>
        /// Get a scorer object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScorerReadRes> ScorerReadV2EntityProjectScorersObjectIdVersionsDigestGetAsync(
            string entity,
            string project,
            string objectId,
            string digest,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}