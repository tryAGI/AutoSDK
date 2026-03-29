//HintName: G.IModelClient.DeleteModelById.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Delete Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteModelByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}