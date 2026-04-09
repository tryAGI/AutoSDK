//HintName: G.ICustomModelsClient.V1UpdateCustomModel.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1UpdateCustomModelAsync(
            string customModelPid,

            global::G.CustomModelUpdateBody request,
            int? requestStartTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="defaultEpoch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1UpdateCustomModelAsync(
            string customModelPid,
            int? requestStartTime = default,
            int? defaultEpoch = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}