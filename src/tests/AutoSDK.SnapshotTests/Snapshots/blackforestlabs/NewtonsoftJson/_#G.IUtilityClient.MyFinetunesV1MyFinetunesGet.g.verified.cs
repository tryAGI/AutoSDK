//HintName: G.IUtilityClient.MyFinetunesV1MyFinetunesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// My Finetunes<br/>
        /// List all finetune_ids created by the user
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MyFinetunesResponse> MyFinetunesV1MyFinetunesGetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}