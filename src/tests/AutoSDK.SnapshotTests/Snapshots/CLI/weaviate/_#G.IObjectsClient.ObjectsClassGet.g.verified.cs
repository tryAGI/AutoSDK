//HintName: G.IObjectsClient.ObjectsClassGet.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Get an object.<br/>
        /// Get a data object based on its collection and UUID. Also available as Websocket bus.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="nodeName"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Object> ObjectsClassGetAsync(
            string className,
            global::System.Guid id,
            string? include = default,
            global::G.ObjectsClassGetConsistencyLevel? consistencyLevel = default,
            string? nodeName = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}