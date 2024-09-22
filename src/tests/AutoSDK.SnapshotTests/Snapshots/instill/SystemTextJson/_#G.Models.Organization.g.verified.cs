//HintName: G.Models.Organization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organizations group several users. As entities, they can own resources such<br/>
    /// as pipelines or releases.
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// The name of the organization, defined by its ID.<br/>
        /// - Format: `organization/{organization.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Organization UUID.<br/>
        /// Included only in responses
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
        /// Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The user that owns the organization.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::G.User? Owner { get; set; }

        /// <summary>
        /// Profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationProfile Profile { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::G.Permission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}