//HintName: G.Models.ApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The API key.
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </summary>
        /// <example>ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38</example>
        [global::Newtonsoft.Json.JsonProperty("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// API key label. The default value is `DeepL API Key`.<br/>
        /// Example: developer key prod
        /// </summary>
        /// <example>developer key prod</example>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Timestamp when the key was created (ISO 8601 format)<br/>
        /// Example: 2025-07-08T08:15:29.362Z
        /// </summary>
        /// <example>2025-07-08T08:15:29.362Z</example>
        [global::Newtonsoft.Json.JsonProperty("creation_time")]
        public string? CreationTime { get; set; }

        /// <summary>
        /// Timestamp when the key was deactivated (ISO 8601 format). The default value is `null`.<br/>
        /// Example: 2025-07-09T08:15:29.362Z
        /// </summary>
        /// <example>2025-07-09T08:15:29.362Z</example>
        [global::Newtonsoft.Json.JsonProperty("deactivated_time")]
        public string? DeactivatedTime { get; set; }

        /// <summary>
        /// Flag indicating whether the API key is deactivated. The default value is `false`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_deactivated")]
        public bool? IsDeactivated { get; set; }

        /// <summary>
        /// Usage limits for the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.ApiKeyUsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </param>
        /// <param name="label">
        /// API key label. The default value is `DeepL API Key`.<br/>
        /// Example: developer key prod
        /// </param>
        /// <param name="creationTime">
        /// Timestamp when the key was created (ISO 8601 format)<br/>
        /// Example: 2025-07-08T08:15:29.362Z
        /// </param>
        /// <param name="deactivatedTime">
        /// Timestamp when the key was deactivated (ISO 8601 format). The default value is `null`.<br/>
        /// Example: 2025-07-09T08:15:29.362Z
        /// </param>
        /// <param name="isDeactivated">
        /// Flag indicating whether the API key is deactivated. The default value is `false`.<br/>
        /// Example: true
        /// </param>
        /// <param name="usageLimits">
        /// Usage limits for the API key.
        /// </param>
        public ApiKey(
            string? keyId,
            string? label,
            string? creationTime,
            string? deactivatedTime,
            bool? isDeactivated,
            global::G.ApiKeyUsageLimits? usageLimits)
        {
            this.KeyId = keyId;
            this.Label = label;
            this.CreationTime = creationTime;
            this.DeactivatedTime = deactivatedTime;
            this.IsDeactivated = isDeactivated;
            this.UsageLimits = usageLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }
    }
}