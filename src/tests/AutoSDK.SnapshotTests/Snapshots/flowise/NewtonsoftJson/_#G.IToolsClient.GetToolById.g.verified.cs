//HintName: G.IToolsClient.GetToolById.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get a tool by ID<br/>
        /// Retrieve a specific tool by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> GetToolByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}