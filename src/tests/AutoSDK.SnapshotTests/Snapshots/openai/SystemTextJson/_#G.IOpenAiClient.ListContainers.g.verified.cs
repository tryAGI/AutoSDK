//HintName: G.IOpenAiClient.ListContainers.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List Containers<br/>
        /// Lists containers.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContainerListResource> ListContainersAsync(
            int? limit = default,
            global::G.ListContainersOrder? order = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}