//HintName: G.IEviToolsClient.DeleteEviTool.g.cs
#nullable enable

namespace G
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Delete an EVI tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEviToolAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}