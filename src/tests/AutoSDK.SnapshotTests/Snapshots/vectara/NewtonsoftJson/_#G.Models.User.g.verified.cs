//HintName: G.Models.User.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// The Vectara ID for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The email address for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The username for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Indicates whether the user is enabled or disabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The description of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the user was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When a user property was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The role names of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// What actions a principal can take on the Vectara platform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_policy")]
        public global::G.ApiPolicy? ApiPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}