//HintName: G.ISecretsClient.UpdateSecret.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Update a Secret<br/>
        /// Update an existing secret.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateSecretResponse> UpdateSecretAsync(
            string id,

            global::G.AnyOf<global::G.AnyOf<global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthentication, global::G.UpdateSecretRequestUpdateSecretRequest1BearerToken, global::G.UpdateSecretRequestUpdateSecretRequest1ApiKey>?, global::G.AnyOf<global::G.UpdateSecretRequestVariant2OpenAIConfiguration, global::G.UpdateSecretRequestVariant2Variant2>?> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Secret<br/>
        /// Update an existing secret.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateSecretResponse> UpdateSecretAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}