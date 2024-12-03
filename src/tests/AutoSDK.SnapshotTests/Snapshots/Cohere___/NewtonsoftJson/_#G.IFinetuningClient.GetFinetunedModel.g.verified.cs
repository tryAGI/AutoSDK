//HintName: G.IFinetuningClient.GetFinetunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Returns a fine-tuned model by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFinetunedModelResponse> GetFinetunedModelAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}