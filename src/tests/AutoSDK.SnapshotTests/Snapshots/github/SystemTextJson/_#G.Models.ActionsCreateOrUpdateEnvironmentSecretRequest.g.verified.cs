//HintName: G.Models.ActionsCreateOrUpdateEnvironmentSecretRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCreateOrUpdateEnvironmentSecretRequest
    {
        /// <summary>
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an environment public key](https://docs.github.com/rest/actions/secrets#get-an-environment-public-key) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedValue { get; set; }

        /// <summary>
        /// ID of the key you used to encrypt the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateOrUpdateEnvironmentSecretRequest" /> class.
        /// </summary>
        /// <param name="encryptedValue">
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an environment public key](https://docs.github.com/rest/actions/secrets#get-an-environment-public-key) endpoint.
        /// </param>
        /// <param name="keyId">
        /// ID of the key you used to encrypt the secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCreateOrUpdateEnvironmentSecretRequest(
            string encryptedValue,
            string keyId)
        {
            this.EncryptedValue = encryptedValue ?? throw new global::System.ArgumentNullException(nameof(encryptedValue));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateOrUpdateEnvironmentSecretRequest" /> class.
        /// </summary>
        public ActionsCreateOrUpdateEnvironmentSecretRequest()
        {
        }
    }
}