//HintName: G.IClientKeysClient.GetClientKey.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Get Client Key
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.GetClientKeyResponse> GetClientKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}