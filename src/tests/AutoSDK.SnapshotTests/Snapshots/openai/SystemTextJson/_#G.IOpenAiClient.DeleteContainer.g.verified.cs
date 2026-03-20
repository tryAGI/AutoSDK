//HintName: G.IOpenAiClient.DeleteContainer.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Delete Container<br/>
        /// Delete a container.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteContainerAsync(
            string containerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}