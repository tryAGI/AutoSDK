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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("primary_key_id")]
        public int? PrimaryKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_key")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails")]
        public global::System.Collections.Generic.IList<global::G.GpgKeySubkeyEmail>? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subkeys")]
        public global::System.Collections.Generic.IList<object>? Subkeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_sign")]
        public bool? CanSign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_encrypt_comms")]
        public bool? CanEncryptComms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_encrypt_storage")]
        public bool? CanEncryptStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_certify")]
        public bool? CanCertify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_key")]
        public string? RawKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("revoked")]
        public bool? Revoked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GpgKeySubkey? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GpgKeySubkey>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GpgKeySubkey?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GpgKeySubkey?>(serializer.Deserialize<global::G.GpgKeySubkey>(jsonReader));
        }

    }
}