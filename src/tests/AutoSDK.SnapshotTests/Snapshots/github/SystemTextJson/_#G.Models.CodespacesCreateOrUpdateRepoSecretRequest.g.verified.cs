//HintName: G.Models.CodespacesCreateOrUpdateRepoSecretRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCreateOrUpdateRepoSecretRequest
    {
        /// <summary>
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get a repository public key](https://docs.github.com/rest/codespaces/repository-secrets#get-a-repository-public-key) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_value")]
        public string? EncryptedValue { get; set; }

        /// <summary>
        /// ID of the key you used to encrypt the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateOrUpdateRepoSecretRequest" /> class.
        /// </summary>
        /// <param name="encryptedValue">
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get a repository public key](https://docs.github.com/rest/codespaces/repository-secrets#get-a-repository-public-key) endpoint.
        /// </param>
        /// <param name="keyId">
        /// ID of the key you used to encrypt the secret.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespacesCreateOrUpdateRepoSecretRequest(
            string? encryptedValue,
            string? keyId)
        {
            this.EncryptedValue = encryptedValue;
            this.KeyId = keyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateOrUpdateRepoSecretRequest" /> class.
        /// </summary>
        public CodespacesCreateOrUpdateRepoSecretRequest()
        {
        }
    }
}