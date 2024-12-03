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
        /// Unique identifier of the repository invitation.<br/>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Invitee { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inviter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Inviter { get; set; } = default!;

        /// <summary>
        /// The permission associated with the invitation.<br/>
        /// Example: read
        /// </summary>
        /// <example>read</example>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryInvitationPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Whether or not the invitation has expired
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// URL for the repository invitation<br/>
        /// Example: https://api.github.com/user/repository-invitations/1
        /// </summary>
        /// <example>https://api.github.com/user/repository-invitations/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/invitations
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/invitations</example>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInvitation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the repository invitation.<br/>
        /// Example: 42L
        /// </param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="invitee">
        /// A GitHub user.
        /// </param>
        /// <param name="inviter">
        /// A GitHub user.
        /// </param>
        /// <param name="permissions">
        /// The permission associated with the invitation.<br/>
        /// Example: read
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="expired">
        /// Whether or not the invitation has expired
        /// </param>
        /// <param name="url">
        /// URL for the repository invitation<br/>
        /// Example: https://api.github.com/user/repository-invitations/1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/invitations
        /// </param>
        /// <param name="nodeId"></param>
        public RepositoryInvitation(
            long id,
            global::G.MinimalRepository repository,
            global::G.NullableSimpleUser? invitee,
            global::G.NullableSimpleUser? inviter,
            global::G.RepositoryInvitationPermissions permissions,
            global::System.DateTime createdAt,
            string url,
            string htmlUrl,
            string nodeId,
            bool? expired)
        {
            this.Id = id;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Invitee = invitee ?? throw new global::System.ArgumentNullException(nameof(invitee));
            this.Inviter = inviter ?? throw new global::System.ArgumentNullException(nameof(inviter));
            this.Permissions = permissions;
            this.CreatedAt = createdAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInvitation" /> class.
        /// </summary>
        public RepositoryInvitation()
        {
        }
    }
}