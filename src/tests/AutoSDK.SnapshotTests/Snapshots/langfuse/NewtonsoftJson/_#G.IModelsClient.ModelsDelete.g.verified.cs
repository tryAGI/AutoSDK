//HintName: G.IModelsClient.ModelsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete a model. Cannot delete models managed by Langfuse. You can create your own definition with the same modelName to override the definition though.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ModelsDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}