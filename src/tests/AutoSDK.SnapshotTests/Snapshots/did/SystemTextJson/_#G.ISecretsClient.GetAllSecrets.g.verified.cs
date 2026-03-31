//HintName: G.ISecretsClient.GetAllSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// List Secrets<br/>
        /// Retrieve all secrets for the authenticated user.<br/>
        /// Returns a list of secrets with sanitized (masked) secret values.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GetAllSecretsResponseItem>> GetAllSecretsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}