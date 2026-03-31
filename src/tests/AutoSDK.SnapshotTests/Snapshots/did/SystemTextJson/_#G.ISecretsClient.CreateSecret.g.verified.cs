//HintName: G.ISecretsClient.CreateSecret.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Create a Secret
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSecretResponse> CreateSecretAsync(

            global::G.AnyOf<global::G.AnyOf<global::G.CreateSecretRequestCreateSecretRequest1BasicAuthentication, global::G.CreateSecretRequestCreateSecretRequest1BearerToken, global::G.CreateSecretRequestCreateSecretRequest1ApiKey>?, global::G.AnyOf<global::G.CreateSecretRequestVariant2OpenAIConfiguration, global::G.CreateSecretRequestVariant2Variant2>?> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secret
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSecretResponse> CreateSecretAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}