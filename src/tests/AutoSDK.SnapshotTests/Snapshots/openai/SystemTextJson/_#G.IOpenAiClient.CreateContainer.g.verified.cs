//HintName: G.IOpenAiClient.CreateContainer.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create Container<br/>
        /// Creates a container.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerResource> CreateContainerAsync(
            global::G.CreateContainerBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Container<br/>
        /// Creates a container.
        /// </summary>
        /// <param name="name">
        /// Name of the container to create.
        /// </param>
        /// <param name="fileIds">
        /// IDs of files to copy to the container.
        /// </param>
        /// <param name="expiresAfter">
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerResource> CreateContainerAsync(
            string name,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            global::G.CreateContainerBodyExpiresAfter? expiresAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}