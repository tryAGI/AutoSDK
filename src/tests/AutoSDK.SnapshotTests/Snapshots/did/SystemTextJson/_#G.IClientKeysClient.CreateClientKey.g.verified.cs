//HintName: G.IClientKeysClient.CreateClientKey.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Create a new Client Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> CreateClientKeyAsync(

            global::G.CreateClientKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Client Key
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> CreateClientKeyAsync(
            global::System.Collections.Generic.IList<string> allowedDomains,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}