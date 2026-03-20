//HintName: G.IModelsClient.DeleteModelV1ModelsModelIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete Model<br/>
        /// Delete a fine-tuned model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteModelOut> DeleteModelV1ModelsModelIdDeleteAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}