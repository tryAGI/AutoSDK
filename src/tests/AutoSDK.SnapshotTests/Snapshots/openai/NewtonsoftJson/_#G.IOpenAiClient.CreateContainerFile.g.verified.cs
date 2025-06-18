//HintName: G.IOpenAiClient.CreateContainerFile.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create a Container File<br/>
        /// You can send either a multipart/form-data request with the raw file content, or a JSON request with a file ID.<br/>
        /// Creates a container file.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerFileResource> CreateContainerFileAsync(
            string containerId,
            global::G.CreateContainerFileBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Container File<br/>
        /// You can send either a multipart/form-data request with the raw file content, or a JSON request with a file ID.<br/>
        /// Creates a container file.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="fileId">
        /// Name of the file to create.
        /// </param>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerFileResource> CreateContainerFileAsync(
            string containerId,
            string? fileId = default,
            byte[]? file = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}