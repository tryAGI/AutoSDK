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
        public global::G.NullableSimpleUser? Author { get; set; } = default!;

        /// <summary>
        /// The main text of the discussion.<br/>
        /// Example: Please suggest improvements to our workflow in comments.
        /// </summary>
        /// <example>Please suggest improvements to our workflow in comments.</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Example: &lt;p&gt;Hi! This is an area for us to collaborate as a team&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Hi! This is an area for us to collaborate as a team&lt;/p&gt;</example>
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
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("comments_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CommentsCount { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2343027/discussions/1/comments
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2343027/discussions/1/comments</example>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_edited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? LastEditedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/orgs/github/teams/justice-league/discussions/1
        /// </summary>
        /// <example>https://github.com/orgs/github/teams/justice-league/discussions/1</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: MDE0OlRlYW1EaXNjdXNzaW9uMQ==
        /// </summary>
        /// <example>MDE0OlRlYW1EaXNjdXNzaW9uMQ==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The unique sequence number of a team discussion.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Whether or not this discussion should be pinned for easy retrieval.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pinned { get; set; } = default!;

        /// <summary>
        /// Whether or not this discussion should be restricted to team members and organization owners.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2343027
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2343027</example>
        [global::Newtonsoft.Json.JsonProperty("team_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamUrl { get; set; } = default!;

        /// <summary>
        /// The title of the discussion.<br/>
        /// Example: How can we improve our workflow?
        /// </summary>
        /// <example>How can we improve our workflow?</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2343027/discussions/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2343027/discussions/1</example>
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
        /// Initializes a new instance of the <see cref="TeamDiscussion" /> class.
        /// </summary>
        /// <param name="author">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// The main text of the discussion.<br/>
        /// Example: Please suggest improvements to our workflow in comments.
        /// </param>
        /// <param name="bodyHtml">
        /// Example: &lt;p&gt;Hi! This is an area for us to collaborate as a team&lt;/p&gt;
        /// </param>
        /// <param name="bodyVersion">
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.<br/>
        /// Example: 0307116bbf7ced493b8d8a346c650b71
        /// </param>
        /// <param name="commentsCount">
        /// Example: 0
        /// </param>
        /// <param name="commentsUrl">
        /// Example: https://api.github.com/organizations/1/team/2343027/discussions/1/comments
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="lastEditedAt"></param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/github/teams/justice-league/discussions/1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDE0OlRlYW1EaXNjdXNzaW9uMQ==
        /// </param>
        /// <param name="number">
        /// The unique sequence number of a team discussion.<br/>
        /// Example: 42
        /// </param>
        /// <param name="pinned">
        /// Whether or not this discussion should be pinned for easy retrieval.<br/>
        /// Example: true
        /// </param>
        /// <param name="private">
        /// Whether or not this discussion should be restricted to team members and organization owners.<br/>
        /// Example: true
        /// </param>
        /// <param name="teamUrl">
        /// Example: https://api.github.com/organizations/1/team/2343027
        /// </param>
        /// <param name="title">
        /// The title of the discussion.<br/>
        /// Example: How can we improve our workflow?
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/organizations/1/team/2343027/discussions/1
        /// </param>
        /// <param name="reactions"></param>
        public TeamDiscussion(
            global::G.NullableSimpleUser? author,
            string body,
            string bodyHtml,
            string bodyVersion,
            int commentsCount,
            string commentsUrl,
            global::System.DateTime createdAt,
            global::System.DateTime? lastEditedAt,
            string htmlUrl,
            string nodeId,
            int number,
            bool pinned,
            bool @private,
            string teamUrl,
            string title,
            global::System.DateTime updatedAt,
            string url,
            global::G.ReactionRollup? reactions)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.BodyHtml = bodyHtml ?? throw new global::System.ArgumentNullException(nameof(bodyHtml));
            this.BodyVersion = bodyVersion ?? throw new global::System.ArgumentNullException(nameof(bodyVersion));
            this.CommentsCount = commentsCount;
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.CreatedAt = createdAt;
            this.LastEditedAt = lastEditedAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.Pinned = pinned;
            this.Private = @private;
            this.TeamUrl = teamUrl ?? throw new global::System.ArgumentNullException(nameof(teamUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDiscussion" /> class.
        /// </summary>
        public TeamDiscussion()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TeamDiscussion? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TeamDiscussion>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TeamDiscussion?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.TeamDiscussion?>(serializer.Deserialize<global::G.TeamDiscussion>(jsonReader));
        }

    }
}