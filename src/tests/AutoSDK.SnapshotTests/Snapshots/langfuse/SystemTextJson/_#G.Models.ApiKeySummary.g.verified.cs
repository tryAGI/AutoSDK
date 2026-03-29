//HintName: G.Models.ApiKeySummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of an API key
    /// </summary>
    public sealed partial class ApiKeySummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displaySecretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplaySecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeySummary" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="publicKey"></param>
        /// <param name="displaySecretKey"></param>
        /// <param name="expiresAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeySummary(
            string id,
            global::System.DateTime createdAt,
            string publicKey,
            string displaySecretKey,
            global::System.DateTime? expiresAt,
            global::System.DateTime? lastUsedAt,
            string? note)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.LastUsedAt = lastUsedAt;
            this.Note = note;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.DisplaySecretKey = displaySecretKey ?? throw new global::System.ArgumentNullException(nameof(displaySecretKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeySummary" /> class.
        /// </summary>
        public ApiKeySummary()
        {
        }
    }
}