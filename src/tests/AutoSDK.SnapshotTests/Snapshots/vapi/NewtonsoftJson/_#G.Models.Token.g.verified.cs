//HintName: G.Models.Token.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Token
    {
        /// <summary>
        /// This is the tag for the token. It represents its scope.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::G.TokenTag? Tag { get; set; }

        /// <summary>
        /// This is the unique identifier for the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is unique identifier for the org that this token belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the token was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the token was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the token key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// This is the name of the token. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This are the restrictions for the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions")]
        public global::G.TokenRestrictions? Restrictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the token.
        /// </param>
        /// <param name="orgId">
        /// This is unique identifier for the org that this token belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the token was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the token was last updated.
        /// </param>
        /// <param name="tag">
        /// This is the tag for the token. It represents its scope.
        /// </param>
        /// <param name="value">
        /// This is the token key.
        /// </param>
        /// <param name="name">
        /// This is the name of the token. This is just for your own reference.
        /// </param>
        /// <param name="restrictions">
        /// This are the restrictions for the token.
        /// </param>
        public Token(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.TokenTag? tag,
            string? value,
            string? name,
            global::G.TokenRestrictions? restrictions)
        {
            this.Tag = tag;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Value = value;
            this.Name = name;
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        public Token()
        {
        }
    }
}