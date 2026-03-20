//HintName: G.ICloudClient.DeleteCloudCredential.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Delete Cloud Credential
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCloudCredentialAsync(
            string credentialId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}