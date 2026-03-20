//HintName: G.IGenerationsClient.DeleteGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Delete a generation<br/>
        /// Remove a specific generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteGenerationAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}