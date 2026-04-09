//HintName: G.IApi.V2FinetunedModelsDeleteV2FinetunedModelsFinetunedModelIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete Fine-tuned Model<br/>
        /// Delete a previously saved finetuned model. It takes the ID of the model that you want to delete as a path parameter.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2FinetunedModelsDeleteV2FinetunedModelsFinetunedModelIdDeleteAsync(
            string finetunedModelId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}