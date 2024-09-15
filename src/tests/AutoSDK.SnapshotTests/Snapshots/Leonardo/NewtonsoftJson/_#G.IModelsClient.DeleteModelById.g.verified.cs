//HintName: G.IModelsClient.DeleteModelById.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete a Single Custom Model by ID<br/>
        /// This endpoint will delete a specific custom model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteModelByIdResponse> DeleteModelByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}