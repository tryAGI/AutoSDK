//HintName: G.IApi.V2FinetunedModelV2FinetunedModelsFinetunedModelIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get single Fine-tuned Model<br/>
        /// Retrieve metadata for a previously fine-tuned model. The response contains the metadata of a model that you have fine-tuned and is available to make forecasts.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetunedModel> V2FinetunedModelV2FinetunedModelsFinetunedModelIdGetAsync(
            string finetunedModelId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}