//HintName: G.IModelsClient.Models.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List all models<br/>
        /// Lists all of Together's open-source models
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ModelInfo>> ModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}