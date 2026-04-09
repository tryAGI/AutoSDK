//HintName: G.IApi.TunedModelsTransferOwnership.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Transfers ownership of the tuned model. This is the only way to change ownership of the tuned model. The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TransferOwnershipResponse> TunedModelsTransferOwnershipAsync(
            string tunedModelsId,

            global::G.TransferOwnershipRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfers ownership of the tuned model. This is the only way to change ownership of the tuned model. The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="emailAddress">
        /// Required. The email address of the user to whom the tuned model is being transferred to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TransferOwnershipResponse> TunedModelsTransferOwnershipAsync(
            string tunedModelsId,
            string? emailAddress = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}