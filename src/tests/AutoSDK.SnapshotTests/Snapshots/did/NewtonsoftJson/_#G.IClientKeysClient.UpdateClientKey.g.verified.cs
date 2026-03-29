//HintName: G.IClientKeysClient.UpdateClientKey.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Update Client Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task UpdateClientKeyAsync(

            global::G.UpdateClientKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Client Key
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task UpdateClientKeyAsync(
            global::System.Collections.Generic.IList<string> allowedDomains,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}