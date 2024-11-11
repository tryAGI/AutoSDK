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
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("short_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ShortKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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