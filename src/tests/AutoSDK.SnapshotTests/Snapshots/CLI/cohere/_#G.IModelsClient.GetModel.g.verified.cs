//HintName: G.IModelsClient.GetModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get a Model<br/>
        /// Returns the details of a model, provided its name.
        /// </summary>
        /// <param name="model">
        /// Example: command-a-03-2025
        /// </param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelResponse> GetModelAsync(
            string model,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}