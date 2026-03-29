//HintName: G.ISecretReferencesClient.DeleteSecretReference.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretReferencesClient
    {
        /// <summary>
        /// Delete a Secret Reference
        /// </summary>
        /// <param name="secretReferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSecretReferenceAsync(
            string secretReferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}