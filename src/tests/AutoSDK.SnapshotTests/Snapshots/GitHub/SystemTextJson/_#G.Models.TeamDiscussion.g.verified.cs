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
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Author { get; set; }

        /// <summary>
        /// The main text of the discussion.<br/>
        /// Example: Please suggest improvements to our workflow in comments.
        /// </summary>
        /// <example>Please suggest improvements to our workflow in comments.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Example: &lt;p&gt;Hi! This is an area for us to collaborate as a team&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Hi! This is an area for us to collaborate as a team&lt;/p&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodyHtml { get; set; }

        /// <summary>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.<br/>
        /// Example: 0307116bbf7ced493b8d8a346c650b71
        /// </summary>
        /// <example>0307116bbf7ced493b8d8a346c650b71</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodyVersion { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentsCount { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2343027/discussions/1/comments
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2343027/discussions/1/comments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_edited_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? LastEditedAt { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/github/teams/justice-league/discussions/1
        /// </summary>
        /// <example>https://github.com/orgs/github/teams/justice-league/discussions/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: MDE0OlRlYW1EaXNjdXNzaW9uMQ==
        /// </summary>
        /// <example>MDE0OlRlYW1EaXNjdXNzaW9uMQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The unique sequence number of a team discussion.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// Whether or not this discussion should be pinned for easy retrieval.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// Whether or not this discussion should be restricted to team members and organization owners.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2343027
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2343027</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamUrl { get; set; }

        /// <summary>
        /// The title of the discussion.<br/>
        /// Example: How can we improve our workflow?
        /// </summary>
        /// <example>How can we improve our workflow?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2343027/discussions/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/2343027/discussions/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.TeamDiscussion? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.TeamDiscussion),
                jsonSerializerContext) as global::G.TeamDiscussion;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.TeamDiscussion>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.TeamDiscussion?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.TeamDiscussion),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.TeamDiscussion;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.TeamDiscussion?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}