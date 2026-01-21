//HintName: G.IFinetuningClient.CreateFinetunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Trains and deploys a fine-tuned model.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFinetunedModelResponse> CreateFinetunedModelAsync(
            global::G.FinetunedModel request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trains and deploys a fine-tuned model.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="settings">
        /// FinetunedModel settings such as dataset, hyperparameters...
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFinetunedModelResponse> CreateFinetunedModelAsync(
            string name,
            global::G.Settings settings,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}