//HintName: G.IModelsClient.JobsApiRoutesFineTuningArchiveFineTunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Archive Fine Tuned Model<br/>
        /// Archive a fine-tuned model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ArchiveFTModelOut> JobsApiRoutesFineTuningArchiveFineTunedModelAsync(
            string modelId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}