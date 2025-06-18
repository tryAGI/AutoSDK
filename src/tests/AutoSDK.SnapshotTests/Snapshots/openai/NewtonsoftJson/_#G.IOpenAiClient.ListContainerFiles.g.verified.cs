//HintName: G.IOpenAiClient.ListContainerFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List Container files<br/>
        /// Lists container files.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerFileListResource> ListContainerFilesAsync(
            string containerId,
            int? limit = default,
            global::G.ListContainerFilesOrder? order = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}