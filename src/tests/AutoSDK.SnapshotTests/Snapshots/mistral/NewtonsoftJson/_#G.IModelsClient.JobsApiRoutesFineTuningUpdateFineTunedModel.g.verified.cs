//HintName: G.IModelsClient.JobsApiRoutesFineTuningUpdateFineTunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Update Fine Tuned Model<br/>
        /// Update a model name or description.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponse> JobsApiRoutesFineTuningUpdateFineTunedModelAsync(
            string modelId,
            global::G.UpdateFTModelIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Fine Tuned Model<br/>
        /// Update a model name or description.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponse> JobsApiRoutesFineTuningUpdateFineTunedModelAsync(
            string modelId,
            string? description = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}