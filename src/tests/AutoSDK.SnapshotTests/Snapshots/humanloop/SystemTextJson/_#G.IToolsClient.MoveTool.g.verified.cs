//HintName: G.IToolsClient.MoveTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Move Tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolResponse> MoveToolAsync(
            string id,

            global::G.MoveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path">
        /// New path to move the file to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolResponse> MoveToolAsync(
            string id,
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}