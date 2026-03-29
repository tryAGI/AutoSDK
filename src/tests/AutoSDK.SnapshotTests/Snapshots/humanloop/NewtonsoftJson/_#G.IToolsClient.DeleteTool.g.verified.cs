//HintName: G.IToolsClient.DeleteTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Delete Tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteToolAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}