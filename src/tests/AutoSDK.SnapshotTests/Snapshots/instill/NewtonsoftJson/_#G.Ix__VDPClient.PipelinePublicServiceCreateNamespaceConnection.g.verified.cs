//HintName: G.Ix__VDPClient.PipelinePublicServiceCreateNamespaceConnection.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Create a connection<br/>
        /// Creates a connection under the ownership of a namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespaceConnectionResponse> PipelinePublicServiceCreateNamespaceConnectionAsync(
            string namespaceId,
            global::G.Connection request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a connection<br/>
        /// Creates a connection under the ownership of a namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="id">
        /// ID.
        /// </param>
        /// <param name="integrationId">
        /// Integration ID. It determines for which type of components can reference<br/>
        /// this connection.
        /// </param>
        /// <param name="method">
        /// Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </param>
        /// <param name="setup">
        /// Connection details. This field is required on creation, optional on view.<br/>
        /// When viewing the connection details, the setup values will be redacted.
        /// </param>
        /// <param name="scopes">
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf. This is typically passed on creation<br/>
        /// when the setup has been generated through an OAuth flow with a limited set<br/>
        /// of scopes.
        /// </param>
        /// <param name="identity">
        /// When the connection method is METHOD_OAUTH, this field will hold the<br/>
        /// identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </param>
        /// <param name="oAuthAccessDetails">
        /// When the connection method is METHOD_OAUTH, the access token might come<br/>
        /// with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespaceConnectionResponse> PipelinePublicServiceCreateNamespaceConnectionAsync(
            string namespaceId,
            string id,
            string integrationId,
            global::G.Method method,
            object setup,
            global::System.Collections.Generic.IList<string>? scopes = default,
            string? identity = default,
            object? oAuthAccessDetails = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}