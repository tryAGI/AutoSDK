//HintName: G.INamespaceClient.CheckNamespace.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Check if a namespace is in use<br/>
        /// Returns the availability of a namespace or, alternatively, the type of<br/>
        /// resource that is using it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckNamespaceResponse> CheckNamespaceAsync(
            global::G.CheckNamespaceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check if a namespace is in use<br/>
        /// Returns the availability of a namespace or, alternatively, the type of<br/>
        /// resource that is using it.
        /// </summary>
        /// <param name="id">
        /// The namespace ID to be checked.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckNamespaceResponse> CheckNamespaceAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}