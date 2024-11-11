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
        /// Example: 3L
        /// </summary>
        /// <example>3L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: Octocat's GPG Key
        /// </summary>
        /// <example>Octocat's GPG Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? PrimaryKeyId { get; set; }

        /// <summary>
        /// Example: 3262EFF25BA0D270
        /// </summary>
        /// <example>3262EFF25BA0D270</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Example: xsBNBFayYZ...
        /// </summary>
        /// <example>xsBNBFayYZ...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GpgKeyEmail> Emails { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subkeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GpgKeySubkey> Subkeys { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
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
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_certify")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanCertify { get; set; }

        /// <summary>
        /// 
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
        /// Example: true
        /// </summary>
        /// <example>true</example>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 3L
        /// </param>
        /// <param name="name">
        /// Example: Octocat's GPG Key
        /// </param>
        /// <param name="primaryKeyId"></param>
        /// <param name="keyId">
        /// Example: 3262EFF25BA0D270
        /// </param>
        /// <param name="publicKey">
        /// Example: xsBNBFayYZ...
        /// </param>
        /// <param name="emails">
        /// Example: []
        /// </param>
        /// <param name="subkeys">
        /// Example: []
        /// </param>
        /// <param name="canSign">
        /// Example: true
        /// </param>
        /// <param name="canEncryptComms"></param>
        /// <param name="canEncryptStorage"></param>
        /// <param name="canCertify">
        /// Example: true
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="revoked">
        /// Example: true
        /// </param>
        /// <param name="rawKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GpgKey(
            long id,
            int? primaryKeyId,
            string keyId,
            string publicKey,
            global::System.Collections.Generic.IList<global::G.GpgKeyEmail> emails,
            global::System.Collections.Generic.IList<global::G.GpgKeySubkey> subkeys,
            bool canSign,
            bool canEncryptComms,
            bool canEncryptStorage,
            bool canCertify,
            global::System.DateTime createdAt,
            global::System.DateTime? expiresAt,
            bool revoked,
            string? rawKey,
            string? name)
        {
            this.Id = id;
            this.PrimaryKeyId = primaryKeyId;
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Subkeys = subkeys ?? throw new global::System.ArgumentNullException(nameof(subkeys));
            this.CanSign = canSign;
            this.CanEncryptComms = canEncryptComms;
            this.CanEncryptStorage = canEncryptStorage;
            this.CanCertify = canCertify;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Revoked = revoked;
            this.RawKey = rawKey ?? throw new global::System.ArgumentNullException(nameof(rawKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKey" /> class.
        /// </summary>
        public GpgKey()
        {
        }
    }
}