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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: Octocat's GPG Key
        /// </summary>
        /// <example>Octocat's GPG Key</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("primary_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? PrimaryKeyId { get; set; } = default!;

        /// <summary>
        /// Example: 3262EFF25BA0D270
        /// </summary>
        /// <example>3262EFF25BA0D270</example>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// Example: xsBNBFayYZ...
        /// </summary>
        /// <example>xsBNBFayYZ...</example>
        [global::Newtonsoft.Json.JsonProperty("public_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; } = default!;

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GpgKeyEmail> Emails { get; set; } = default!;

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("subkeys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GpgKeySubkey> Subkeys { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("can_sign", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanSign { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_encrypt_comms", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanEncryptComms { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_encrypt_storage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanEncryptStorage { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("can_certify", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanCertify { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("revoked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Revoked { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RawKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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