//HintName: G.ICustomModelsClient.V1CreateCustomModel.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Create Custom Model
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1CreateCustomModelAsync(

            global::G.CustomModelInput request,
            int? requestStartTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Custom Model
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="modelType">
        /// An enumeration.
        /// </param>
        /// <param name="learningRate"></param>
        /// <param name="numEpochs"></param>
        /// <param name="datasetId"></param>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1CreateCustomModelAsync(
            global::G.CustomModelType modelType,
            string datasetId,
            string modelName,
            int? requestStartTime = default,
            double? learningRate = default,
            int? numEpochs = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}