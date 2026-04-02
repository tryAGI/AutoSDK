//HintName: G.IAdminApiClient.AdminRenameDeveloperKey.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Rename a developer key as an admin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> AdminRenameDeveloperKeyAsync(

            global::G.AdminRenameDeveloperKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename a developer key as an admin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ApiKey>> AdminRenameDeveloperKeyAsResponseAsync(

            global::G.AdminRenameDeveloperKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename a developer key as an admin
        /// </summary>
        /// <param name="keyId">
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </param>
        /// <param name="label">
        /// API key label.<br/>
        /// Example: developer key prod
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> AdminRenameDeveloperKeyAsync(
            string keyId,
            string label,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}