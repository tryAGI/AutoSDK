//HintName: G.Models.DependabotCreateOrUpdateRepoSecretRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependabotCreateOrUpdateRepoSecretRequest
    {
        /// <summary>
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get a repository public key](https://docs.github.com/rest/dependabot/secrets#get-a-repository-public-key) endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_value")]
        public string? EncryptedValue { get; set; }

        /// <summary>
        /// ID of the key you used to encrypt the secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}