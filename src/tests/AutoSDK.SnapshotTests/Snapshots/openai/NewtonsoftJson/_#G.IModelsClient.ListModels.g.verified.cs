//HintName: G.IModelsClient.ListModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Lists the currently available models, and provides basic information about each one such as the owner and availability.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelsResponse> ListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}