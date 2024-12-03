//HintName: G.IFileClient.GetFXMLDocXPolled.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetFXMLDocXPolled<br/>
        /// GetFXMLDocXPolled
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFXMLDocXPolledAsync(
            global::G.GetFXMLDocXPolledRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFXMLDocXPolled<br/>
        /// GetFXMLDocXPolled
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFXMLDocXPolledAsync(
            global::System.Guid projectId,
            string fileURL,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}