//HintName: G.Models.AdminApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKey
    {
        /// <summary>
        /// Example: organization.admin_api_key
        /// </summary>
        /// <example>organization.admin_api_key</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: Administration Key
        /// </summary>
        /// <example>Administration Key</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: sk-admin...def
        /// </summary>
        /// <example>sk-admin...def</example>
        [global::Newtonsoft.Json.JsonProperty("redacted_value")]
        public string? RedactedValue { get; set; }

        /// <summary>
        /// Example: sk-admin-1234abcd
        /// </summary>
        /// <example>sk-admin-1234abcd</example>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Example: 1711471533L
        /// </summary>
        /// <example>1711471533L</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.AdminApiKeyOwner? Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKey" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: organization.admin_api_key
        /// </param>
        /// <param name="id">
        /// Example: key_abc
        /// </param>
        /// <param name="name">
        /// Example: Administration Key
        /// </param>
        /// <param name="redactedValue">
        /// Example: sk-admin...def
        /// </param>
        /// <param name="value">
        /// Example: sk-admin-1234abcd
        /// </param>
        /// <param name="createdAt">
        /// Example: 1711471533L
        /// </param>
        /// <param name="owner"></param>
        public AdminApiKey(
            string? @object,
            string? id,
            string? name,
            string? redactedValue,
            string? value,
            long? createdAt,
            global::G.AdminApiKeyOwner? owner)
        {
            this.Object = @object;
            this.Id = id;
            this.Name = name;
            this.RedactedValue = redactedValue;
            this.Value = value;
            this.CreatedAt = createdAt;
            this.Owner = owner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKey" /> class.
        /// </summary>
        public AdminApiKey()
        {
        }
    }
}