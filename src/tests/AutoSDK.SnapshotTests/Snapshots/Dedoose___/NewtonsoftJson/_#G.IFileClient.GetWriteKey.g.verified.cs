//HintName: G.IFileClient.GetWriteKey.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetWriteKey<br/>
        /// GetWriteKey
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RSAWriteKeyInfo> GetWriteKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}