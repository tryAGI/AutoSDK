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
        /// - Format: `organization/{organization.id}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Organization UUID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Permission defines how a resource can be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.Permission? Permission { get; set; }

        /// <summary>
        /// OrganizationProfile describes the public data of an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationProfile Profile { get; set; } = default!;

        /// <summary>
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.User? Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}