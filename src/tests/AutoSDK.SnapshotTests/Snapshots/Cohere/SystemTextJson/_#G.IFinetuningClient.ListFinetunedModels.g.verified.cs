//HintName: G.IFinetuningClient.ListFinetunedModels.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Lists fine-tuned models.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFinetunedModelsResponse> ListFinetunedModelsAsync(
            string? xClientName = default,
            int? pageSize = default,
            string? pageToken = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}