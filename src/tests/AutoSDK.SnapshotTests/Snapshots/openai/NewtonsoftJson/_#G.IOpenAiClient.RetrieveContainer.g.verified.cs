//HintName: G.IOpenAiClient.RetrieveContainer.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve Container<br/>
        /// Retrieves a container.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerResource> RetrieveContainerAsync(
            string containerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}