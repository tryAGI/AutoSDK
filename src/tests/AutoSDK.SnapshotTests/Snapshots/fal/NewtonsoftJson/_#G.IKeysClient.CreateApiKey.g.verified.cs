//HintName: G.IKeysClient.CreateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Create API Key<br/>
        /// Creates a new API key with the specified alias.<br/>
        /// **Requirements:**<br/>
        /// - Authentication required via admin API key<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
        /// - Keys are immediately active upon creation<br/>
        /// **Common Use Cases:**<br/>
        /// - Programmatic key provisioning for CI/CD pipelines<br/>
        /// - Self-serve key generation for team members<br/>
        /// - Automated key rotation workflows<br/>
        /// - Integration with secret management systems
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApiKeyResponse> CreateApiKeyAsync(

            global::G.CreateApiKeyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Key<br/>
        /// Creates a new API key with the specified alias.<br/>
        /// **Requirements:**<br/>
        /// - Authentication required via admin API key<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
        /// - Keys are immediately active upon creation<br/>
        /// **Common Use Cases:**<br/>
        /// - Programmatic key provisioning for CI/CD pipelines<br/>
        /// - Self-serve key generation for team members<br/>
        /// - Automated key rotation workflows<br/>
        /// - Integration with secret management systems
        /// </summary>
        /// <param name="alias">
        /// Required friendly name for the API key<br/>
        /// Example: Production Key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApiKeyResponse> CreateApiKeyAsync(
            string alias,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}