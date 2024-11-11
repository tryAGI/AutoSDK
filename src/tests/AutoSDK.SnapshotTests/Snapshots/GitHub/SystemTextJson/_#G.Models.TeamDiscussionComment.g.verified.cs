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
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Author { get; set; }

        /// <summary>
        /// The main text of the comment.<br/>
        /// Example: I agree with this suggestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Example: &lt;p&gt;Do you like apples?&lt;/p&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodyHtml { get; set; }

        /// <summary>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.<br/>
        /// Example: 0307116bbf7ced493b8d8a346c650b71
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodyVersion { get; set; }

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
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiscussionUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/github/teams/justice-league/discussions/1/comments/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: MDIxOlRlYW1EaXNjdXNzaW9uQ29tbWVudDE=
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The unique sequence number of a team discussion comment.<br/>
        /// Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1/comments/1
        /// </summary>
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
        /// <param name="createdAt"></param>
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
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/organizations/1/team/2403582/discussions/1/comments/1
        /// </param>
        /// <param name="reactions"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        public static global::G.TeamDiscussionComment? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.TeamDiscussionComment),
                jsonSerializerContext) as global::G.TeamDiscussionComment;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TeamDiscussionComment? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.TeamDiscussionComment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.TeamDiscussionComment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.TeamDiscussionComment),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.TeamDiscussionComment;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TeamDiscussionComment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.TeamDiscussionComment?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}