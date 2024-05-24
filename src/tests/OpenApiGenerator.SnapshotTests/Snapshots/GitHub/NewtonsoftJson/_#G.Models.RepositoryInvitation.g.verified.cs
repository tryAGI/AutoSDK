//HintName: G.Models.RepositoryInvitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository invitations let you manage who you collaborate with.
    /// </summary>
    public sealed partial class RepositoryInvitation
    {
        /// <summary>
        /// Unique identifier of the repository invitation.
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitee", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Invitee { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inviter", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Inviter { get; set; } = default!;

        /// <summary>
        /// The permission associated with the invitation.
        /// <br/>Example: read
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryInvitationPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Whether or not the invitation has expired
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired")]
        public bool Expired { get; set; }

        /// <summary>
        /// URL for the repository invitation
        /// <br/>Example: https://api.github.com/user/repository-invitations/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/invitations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}