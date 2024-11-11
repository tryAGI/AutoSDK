//HintName: G.Models.CodespacesUserPublicKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The public key used for setting user Codespaces' Secrets.
    /// </summary>
    public sealed partial class CodespacesUserPublicKey
    {
        /// <summary>
        /// The identifier for the key.<br/>
        /// Example: 1234567
        /// </summary>
        /// <example>1234567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// The Base64 encoded public key.<br/>
        /// Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </summary>
        /// <example>hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesUserPublicKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// The identifier for the key.<br/>
        /// Example: 1234567
        /// </param>
        /// <param name="key">
        /// The Base64 encoded public key.<br/>
        /// Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespacesUserPublicKey(
            string keyId,
            string key)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesUserPublicKey" /> class.
        /// </summary>
        public CodespacesUserPublicKey()
        {
        }
    }
}