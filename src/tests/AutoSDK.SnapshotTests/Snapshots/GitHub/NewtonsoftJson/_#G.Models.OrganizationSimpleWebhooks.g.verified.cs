//HintName: G.Models.OrganizationSimpleWebhooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
    /// organization, or when the event occurs from activity in a repository owned by an organization.
    /// </summary>
    public sealed partial class OrganizationSimpleWebhooks
    {
        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        /// <example>MDEyOk9yZ2FuaXphdGlvbjE=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github
        /// </summary>
        /// <example>https://api.github.com/orgs/github</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/repos
        /// </summary>
        /// <example>https://api.github.com/orgs/github/repos</example>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/events
        /// </summary>
        /// <example>https://api.github.com/orgs/github/events</example>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        /// <example>https://api.github.com/orgs/github/hooks</example>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/issues
        /// </summary>
        /// <example>https://api.github.com/orgs/github/issues</example>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        /// <example>https://api.github.com/orgs/github/members{/member}</example>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        /// <example>https://api.github.com/orgs/github/public_members{/member}</example>
        [global::Newtonsoft.Json.JsonProperty("public_members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicMembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Example: A great organization
        /// </summary>
        /// <example>A great organization</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSimpleWebhooks" /> class.
        /// </summary>
        /// <param name="login">
        /// Example: github
        /// </param>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/github
        /// </param>
        /// <param name="reposUrl">
        /// Example: https://api.github.com/orgs/github/repos
        /// </param>
        /// <param name="eventsUrl">
        /// Example: https://api.github.com/orgs/github/events
        /// </param>
        /// <param name="hooksUrl">
        /// Example: https://api.github.com/orgs/github/hooks
        /// </param>
        /// <param name="issuesUrl">
        /// Example: https://api.github.com/orgs/github/issues
        /// </param>
        /// <param name="membersUrl">
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </param>
        /// <param name="publicMembersUrl">
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </param>
        /// <param name="description">
        /// Example: A great organization
        /// </param>
        public OrganizationSimpleWebhooks(
            string login,
            int id,
            string nodeId,
            string url,
            string reposUrl,
            string eventsUrl,
            string hooksUrl,
            string issuesUrl,
            string membersUrl,
            string publicMembersUrl,
            string avatarUrl,
            string? description)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ReposUrl = reposUrl ?? throw new global::System.ArgumentNullException(nameof(reposUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.PublicMembersUrl = publicMembersUrl ?? throw new global::System.ArgumentNullException(nameof(publicMembersUrl));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSimpleWebhooks" /> class.
        /// </summary>
        public OrganizationSimpleWebhooks()
        {
        }
    }
}