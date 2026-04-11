//HintName: G.IUtilityClient.FinetuneDetailsV1FinetuneDetailsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// Finetune Details<br/>
        /// Get details about the training parameters and other metadata connected to a specific finetune_id that was created by the user.
        /// </summary>
        /// <param name="finetuneId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneDetailResponse> FinetuneDetailsV1FinetuneDetailsGetAsync(
            string finetuneId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}