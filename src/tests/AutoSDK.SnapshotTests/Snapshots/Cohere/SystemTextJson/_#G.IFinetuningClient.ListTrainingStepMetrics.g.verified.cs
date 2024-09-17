//HintName: G.IFinetuningClient.ListTrainingStepMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Retrieves metrics measured during the training of a fine-tuned model.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListTrainingStepMetricsResponse> ListTrainingStepMetricsAsync(
            string finetunedModelId,
            int? pageSize = default,
            string? pageToken = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}