//HintName: G.IOpsClient.OpReadV2EntityProjectOpsObjectIdVersionsDigestGet.g.cs
#nullable enable

namespace G
{
    public partial interface IOpsClient
    {
        /// <summary>
        /// Op Read<br/>
        /// Get an op object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="eager">
        /// Whether to eagerly load the op code<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpReadRes> OpReadV2EntityProjectOpsObjectIdVersionsDigestGetAsync(
            string entity,
            string project,
            string objectId,
            string digest,
            bool? eager = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}