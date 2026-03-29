//HintName: G.IToolsClient.GetAllTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List all tools<br/>
        /// Retrieve a list of all tools
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tool>> GetAllToolsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}