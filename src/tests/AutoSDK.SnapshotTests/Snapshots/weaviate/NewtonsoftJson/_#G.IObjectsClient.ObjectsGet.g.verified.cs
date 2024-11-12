//HintName: G.IObjectsClient.ObjectsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// List objects.<br/>
        /// Get a specific object based on its UUID. Also available as Websocket bus.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Object> ObjectsGetAsync(
            global::System.Guid id,
            string? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}