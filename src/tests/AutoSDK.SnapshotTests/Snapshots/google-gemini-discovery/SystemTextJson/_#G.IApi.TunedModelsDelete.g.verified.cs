//HintName: G.IApi.TunedModelsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> TunedModelsDeleteAsync(
            string tunedModelsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}