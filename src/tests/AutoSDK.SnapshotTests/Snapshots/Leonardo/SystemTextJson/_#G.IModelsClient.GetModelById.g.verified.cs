//HintName: G.IModelsClient.GetModelById.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get a Single Custom Model by ID<br/>
        /// This endpoint gets the specific custom model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelByIdResponse> GetModelByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}