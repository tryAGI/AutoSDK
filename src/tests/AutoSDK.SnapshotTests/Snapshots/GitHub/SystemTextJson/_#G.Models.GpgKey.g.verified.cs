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
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: Octocat's GPG Key
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
        /// Example: 3262EFF25BA0D270
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Example: xsBNBFayYZ...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GpgKeyEmail> Emails { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subkeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GpgKeySubkey> Subkeys { get; set; }

        /// <summary>
        /// Example: true
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
        /// Example: true
        /// </summary>
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.GpgKey? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GpgKey),
                jsonSerializerContext) as global::G.GpgKey;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GpgKey? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GpgKey>(
                json,
                jsonSerializerOptions);
        }

    }
}