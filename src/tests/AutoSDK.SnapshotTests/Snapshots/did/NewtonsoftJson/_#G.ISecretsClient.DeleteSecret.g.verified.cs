//HintName: G.ISecretsClient.DeleteSecret.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Delete a Secret<br/>
        /// Delete a secret by its ID.<br/>
        /// This action is permanent and cannot be undone.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteSecretResponse> DeleteSecretAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}