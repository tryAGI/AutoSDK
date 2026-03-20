//HintName: G.IToolsClient.ToolsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolDetail> ToolsRetrieveAsync(
            global::System.Guid toolId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}