//HintName: G.IFileClient.FileGetWriteKey.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetWriteKey.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RSAWriteKeyInfo> FileGetWriteKeyAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}