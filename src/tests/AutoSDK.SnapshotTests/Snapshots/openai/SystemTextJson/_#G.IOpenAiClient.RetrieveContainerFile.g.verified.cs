//HintName: G.IOpenAiClient.RetrieveContainerFile.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve Container File<br/>
        /// Retrieves a container file.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerFileResource> RetrieveContainerFileAsync(
            string containerId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}