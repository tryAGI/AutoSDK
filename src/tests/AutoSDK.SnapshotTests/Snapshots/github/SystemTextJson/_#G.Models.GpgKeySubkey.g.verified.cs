//HintName: G.Models.GpgKeySubkey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GpgKeySubkey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_key_id")]
        public int? PrimaryKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_key")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<global::G.GpgKeySubkeyEmail>? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subkeys")]
        public global::System.Collections.Generic.IList<object>? Subkeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_sign")]
        public bool? CanSign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_encrypt_comms")]
        public bool? CanEncryptComms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_encrypt_storage")]
        public bool? CanEncryptStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_certify")]
        public bool? CanCertify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_key")]
        public string? RawKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        public bool? Revoked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKeySubkey" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="primaryKeyId"></param>
        /// <param name="keyId"></param>
        /// <param name="publicKey"></param>
        /// <param name="emails"></param>
        /// <param name="subkeys"></param>
        /// <param name="canSign"></param>
        /// <param name="canEncryptComms"></param>
        /// <param name="canEncryptStorage"></param>
        /// <param name="canCertify"></param>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="rawKey"></param>
        /// <param name="revoked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpgKeySubkey(
            long? id,
            int? primaryKeyId,
            string? keyId,
            string? publicKey,
            global::System.Collections.Generic.IList<global::G.GpgKeySubkeyEmail>? emails,
            global::System.Collections.Generic.IList<object>? subkeys,
            bool? canSign,
            bool? canEncryptComms,
            bool? canEncryptStorage,
            bool? canCertify,
            string? createdAt,
            string? expiresAt,
            string? rawKey,
            bool? revoked)
        {
            this.Id = id;
            this.PrimaryKeyId = primaryKeyId;
            this.KeyId = keyId;
            this.PublicKey = publicKey;
            this.Emails = emails;
            this.Subkeys = subkeys;
            this.CanSign = canSign;
            this.CanEncryptComms = canEncryptComms;
            this.CanEncryptStorage = canEncryptStorage;
            this.CanCertify = canCertify;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.RawKey = rawKey;
            this.Revoked = revoked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKeySubkey" /> class.
        /// </summary>
        public GpgKeySubkey()
        {
        }
    }
}