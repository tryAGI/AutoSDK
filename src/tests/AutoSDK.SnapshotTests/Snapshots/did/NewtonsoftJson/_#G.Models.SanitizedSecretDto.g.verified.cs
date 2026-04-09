//HintName: G.Models.SanitizedSecretDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SanitizedSecretDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Authentication types supported by the secrets service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SanitizedSecretDtoTypeJsonConverter))]
        public global::G.SanitizedSecretDtoType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastUsedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sanitized_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string SanitizedSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public string? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizedSecretDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="type">
        /// Authentication types supported by the secrets service
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="sanitizedSecret"></param>
        /// <param name="config"></param>
        public SanitizedSecretDto(
            string id,
            string provider,
            global::G.SanitizedSecretDtoType type,
            string createdAt,
            string lastUsedAt,
            string sanitizedSecret,
            string? config)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Type = type;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.LastUsedAt = lastUsedAt ?? throw new global::System.ArgumentNullException(nameof(lastUsedAt));
            this.SanitizedSecret = sanitizedSecret ?? throw new global::System.ArgumentNullException(nameof(sanitizedSecret));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizedSecretDto" /> class.
        /// </summary>
        public SanitizedSecretDto()
        {
        }
    }
}