//HintName: G.Models.Organization7.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Organizations group several users. As entities, they can own resources such<br/>
    /// as pipelines or releases.
    /// </summary>
    public sealed partial class Organization7
    {
        /// <summary>
        /// The name of the organization, defined by its ID.<br/>
        /// - Format: `organization/{organization.id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Organization UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime CreateTime { get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime UpdateTime { get; set; }

        /// <summary>
        /// The user that owns the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.User9>? Owner { get; set; }

        /// <summary>
        /// Profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AllOf<global::G.OrganizationProfile> Profile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.Permission2>? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}