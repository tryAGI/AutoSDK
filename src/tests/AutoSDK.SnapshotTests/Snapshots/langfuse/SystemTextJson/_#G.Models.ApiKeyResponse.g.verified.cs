//HintName: G.Models.ApiKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for API key creation
    /// </summary>
    public sealed partial class ApiKeyResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displaySecretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplaySecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="publicKey"></param>
        /// <param name="secretKey"></param>
        /// <param name="displaySecretKey"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyResponse(
            string id,
            global::System.DateTime createdAt,
            string publicKey,
            string secretKey,
            string displaySecretKey,
            string? note)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
            this.DisplaySecretKey = displaySecretKey ?? throw new global::System.ArgumentNullException(nameof(displaySecretKey));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        public ApiKeyResponse()
        {
        }
    }
}