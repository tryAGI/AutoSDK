//HintName: G.IToolsClient.ListToolVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Tool Versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ToolResponse>> ListToolVersionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}