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
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Invitee { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Inviter { get; set; }

        /// <summary>
        /// The permission associated with the invitation.<br/>
        /// Example: read
        /// </summary>
        /// <example>read</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryInvitationPermissionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryInvitationPermissions Permissions { get; set; }

        /// <summary>
        /// Example: 2016-06-13T14:52:50-05:00
        /// </summary>
        /// <example>2016-06-13T14:52:50-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether or not the invitation has expired
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// URL for the repository invitation<br/>
        /// Example: https://api.github.com/user/repository-invitations/1
        /// </summary>
        /// <example>https://api.github.com/user/repository-invitations/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/invitations
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/invitations</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryInvitation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the repository invitation.<br/>
        /// Example: 42
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
        /// <param name="createdAt">
        /// Example: 2016-06-13T14:52:50-05:00
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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