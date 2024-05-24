//HintName: G.Models.TeamDiscussion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A team discussion is a persistent record of a free-form conversation within a team.
    /// </summary>
    public sealed partial class TeamDiscussion
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Author { get; set; } = default!;

        /// <summary>
        /// The main text of the discussion.
        /// <br/>Example: Please suggest improvements to our workflow in comments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// <br/>Example: &lt;p&gt;Hi! This is an area for us to collaborate as a team&lt;/p&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyHtml { get; set; } = default!;

        /// <summary>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
        /// <br/>Example: 0307116bbf7ced493b8d8a346c650b71
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyVersion { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CommentsCount { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/2343027/discussions/1/comments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_edited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? LastEditedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/orgs/github/teams/justice-league/discussions/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDE0OlRlYW1EaXNjdXNzaW9uMQ==
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The unique sequence number of a team discussion.
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Whether or not this discussion should be pinned for easy retrieval.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pinned { get; set; } = default!;

        /// <summary>
        /// Whether or not this discussion should be restricted to team members and organization owners.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/2343027
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamUrl { get; set; } = default!;

        /// <summary>
        /// The title of the discussion.
        /// <br/>Example: How can we improve our workflow?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/2343027/discussions/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}