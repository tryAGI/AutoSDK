//HintName: G.IModelClient.GetModelById.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelResponse2> GetModelByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}