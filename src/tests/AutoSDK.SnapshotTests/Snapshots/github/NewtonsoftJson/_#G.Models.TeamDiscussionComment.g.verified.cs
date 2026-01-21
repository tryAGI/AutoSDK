//HintName: G.Models.TeamDiscussionComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reply to a discussion within a team.
    /// </summary>
    public sealed partial class TeamDiscussionComment
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Author { get; set; } = default!;

        /// <summary>
        /// The main text of the comment.<br/>
        /// Example: I agree with this suggestion.
        /// </summary>
        /// <example>I agree with this suggestion.</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Example: &lt;p&gt;Do you like apples?&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Do you like apples?&lt;/p&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("body_html", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyHtml { get; set; } = default!;

        /// <summary>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.<br/>
        /// Example: 0307116bbf7ced493b8d8a346c650b71
        /// </summary>
        /// <example>0307116bbf7ced493b8d8a346c650b71</example>
        [global::Newtonsoft.Json.JsonProperty("body_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyVersion { get; set; } = default!;

        /// <summary>
        /// Example: 2018-01-15T23:53:58Z
        /// </summary>
        /// <example>2018-01-15T23:53:58Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_edited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? LastEditedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2403582/discussions/1</example>
        [global::Newtonsoft.Json.JsonProperty("discussion_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiscussionUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/orgs/github/teams/justice-league/discussions/1/comments/1
        /// </summary>
        /// <example>https://github.com/orgs/github/teams/justice-league/discussions/1/comments/1</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: MDIxOlRlYW1EaXNjdXNzaW9uQ29tbWVudDE=
        /// </summary>
        /// <example>MDIxOlRlYW1EaXNjdXNzaW9uQ29tbWVudDE=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The unique sequence number of a team discussion comment.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Example: 2018-01-15T23:53:58Z
        /// </summary>
        /// <example>2018-01-15T23:53:58Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1/comments/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2403582/discussions/1/comments/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDiscussionComment" /> class.
        /// </summary>
        /// <param name="author">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// The main text of the comment.<br/>
        /// Example: I agree with this suggestion.
        /// </param>
        /// <param name="bodyHtml">
        /// Example: &lt;p&gt;Do you like apples?&lt;/p&gt;
        /// </param>
        /// <param name="bodyVersion">
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.<br/>
        /// Example: 0307116bbf7ced493b8d8a346c650b71
        /// </param>
        /// <param name="createdAt">
        /// Example: 2018-01-15T23:53:58Z
        /// </param>
        /// <param name="lastEditedAt"></param>
        /// <param name="discussionUrl">
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/github/teams/justice-league/discussions/1/comments/1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDIxOlRlYW1EaXNjdXNzaW9uQ29tbWVudDE=
        /// </param>
        /// <param name="number">
        /// The unique sequence number of a team discussion comment.<br/>
        /// Example: 42
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2018-01-15T23:53:58Z
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1/comments/1
        /// </param>
        /// <param name="reactions"></param>
        public TeamDiscussionComment(
            global::G.NullableSimpleUser? author,
            string body,
            string bodyHtml,
            string bodyVersion,
            global::System.DateTime createdAt,
            global::System.DateTime? lastEditedAt,
            string discussionUrl,
            string htmlUrl,
            string nodeId,
            int number,
            global::System.DateTime updatedAt,
            string url,
            global::G.ReactionRollup? reactions)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.BodyHtml = bodyHtml ?? throw new global::System.ArgumentNullException(nameof(bodyHtml));
            this.BodyVersion = bodyVersion ?? throw new global::System.ArgumentNullException(nameof(bodyVersion));
            this.CreatedAt = createdAt;
            this.LastEditedAt = lastEditedAt;
            this.DiscussionUrl = discussionUrl ?? throw new global::System.ArgumentNullException(nameof(discussionUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDiscussionComment" /> class.
        /// </summary>
        public TeamDiscussionComment()
        {
        }
    }
}