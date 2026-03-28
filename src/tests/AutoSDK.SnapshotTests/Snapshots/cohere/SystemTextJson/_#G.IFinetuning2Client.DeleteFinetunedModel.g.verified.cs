//HintName: G.IFinetuning2Client.DeleteFinetunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuning2Client
    {
        /// <summary>
        /// Deletes a fine-tuned model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFinetunedModelResponse> DeleteFinetunedModelAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}