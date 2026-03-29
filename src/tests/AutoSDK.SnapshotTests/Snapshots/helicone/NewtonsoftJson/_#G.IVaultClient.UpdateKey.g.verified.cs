//HintName: G.IVaultClient.UpdateKey.g.cs
#nullable enable

namespace G
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateKeyAsync(
            string id,

            global::G.UpdateKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="active"></param>
        /// <param name="name"></param>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateKeyAsync(
            string id,
            bool? active = default,
            string? name = default,
            string? key = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}