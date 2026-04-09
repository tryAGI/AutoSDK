//HintName: G.IModelsClient.JobsApiRoutesFineTuningUnarchiveFineTunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Unarchive Fine Tuned Model<br/>
        /// Un-archive a fine-tuned model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UnarchiveFTModelOut> JobsApiRoutesFineTuningUnarchiveFineTunedModelAsync(
            string modelId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}