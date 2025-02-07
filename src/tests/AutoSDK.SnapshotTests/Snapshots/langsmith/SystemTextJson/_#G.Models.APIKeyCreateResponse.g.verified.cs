//HintName: G.Models.APIKeyCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API key POST schema.
    /// </summary>
    public sealed partial class APIKeyCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreateResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="shortKey"></param>
        /// <param name="description"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="lastUsedAt"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyCreateResponse(
            global::System.Guid id,
            string shortKey,
            string description,
            string key,
            global::System.DateTime? createdAt,
            bool? readOnly,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id;
            this.ShortKey = shortKey ?? throw new global::System.ArgumentNullException(nameof(shortKey));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.CreatedAt = createdAt;
            this.ReadOnly = readOnly;
            this.LastUsedAt = lastUsedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreateResponse" /> class.
        /// </summary>
        public APIKeyCreateResponse()
        {
        }
    }
}