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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedAt")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displaySecretKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplaySecretKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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