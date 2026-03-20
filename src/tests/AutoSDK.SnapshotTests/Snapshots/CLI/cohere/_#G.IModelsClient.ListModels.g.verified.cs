//HintName: G.IModelsClient.ListModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Models<br/>
        /// Returns a list of models available for use. The list contains models from Cohere as well as your fine-tuned models.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="endpoint">
        /// One of the Cohere API endpoints that the model can be used with.
        /// </param>
        /// <param name="defaultOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelsResponse> ListModelsAsync(
            double? pageSize = default,
            string? pageToken = default,
            global::G.CompatibleEndpoint? endpoint = default,
            bool? defaultOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}