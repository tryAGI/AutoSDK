//HintName: G.IOpenAiClient.DeleteContainerFile.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Delete Container File<br/>
        /// Delete a container file.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteContainerFileAsync(
            string containerId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}