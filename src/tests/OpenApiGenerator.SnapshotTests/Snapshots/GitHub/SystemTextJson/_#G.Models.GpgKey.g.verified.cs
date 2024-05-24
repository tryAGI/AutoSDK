//HintName: G.Models.GpgKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A unique encryption key
    /// </summary>
    public sealed partial class GpgKey
    {
        /// <summary>
        /// <br/>Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// <br/>Example: Octocat's GPG Key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? PrimaryKeyId { get; set; }

        /// <summary>
        /// <br/>Example: 3262EFF25BA0D270
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// <br/>Example: xsBNBFayYZ...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// <br/>Example: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<GpgKeyEmails> Emails { get; set; }

        /// <summary>
        /// <br/>Example: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subkeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<GpgKeySubkeys> Subkeys { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_sign")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanSign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_encrypt_comms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanEncryptComms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_encrypt_storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanEncryptStorage { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_certify")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanCertify { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Revoked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RawKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}