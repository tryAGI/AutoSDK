//HintName: G.Models.Discussion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Discussion in a repository.
    /// </summary>
    public sealed partial class Discussion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_chosen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? AnswerChosenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_chosen_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscussionAnswerChosenBy? AnswerChosenBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? AnswerHtmlUrl { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DiscussionAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscussionAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscussionCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.DiscussionReactions? Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// The current state of the discussion.<br/>
        /// `converting` means that the discussion is being converted from an issue.<br/>
        /// `transferring` means that the discussion is being transferred from another repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DiscussionStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscussionState State { get; set; }

        /// <summary>
        /// The reason for the current state<br/>
        /// Example: resolved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DiscussionStateReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscussionStateReason? StateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline_url")]
        public string? TimelineUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscussionUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::G.Label>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Discussion" /> class.
        /// </summary>
        /// <param name="activeLockReason"></param>
        /// <param name="answerChosenAt"></param>
        /// <param name="answerChosenBy"></param>
        /// <param name="answerHtmlUrl"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body"></param>
        /// <param name="category"></param>
        /// <param name="comments"></param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="locked"></param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="reactions"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="state">
        /// The current state of the discussion.<br/>
        /// `converting` means that the discussion is being converted from an issue.<br/>
        /// `transferring` means that the discussion is being transferred from another repository.
        /// </param>
        /// <param name="stateReason">
        /// The reason for the current state<br/>
        /// Example: resolved
        /// </param>
        /// <param name="timelineUrl"></param>
        /// <param name="title"></param>
        /// <param name="updatedAt"></param>
        /// <param name="user"></param>
        /// <param name="labels"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Discussion(
            string? activeLockReason,
            string? answerChosenAt,
            global::G.DiscussionAnswerChosenBy? answerChosenBy,
            string? answerHtmlUrl,
            global::G.DiscussionAuthorAssociation authorAssociation,
            string body,
            global::G.DiscussionCategory category,
            int comments,
            global::System.DateTime createdAt,
            string htmlUrl,
            int id,
            bool locked,
            string nodeId,
            int number,
            string repositoryUrl,
            global::G.DiscussionState state,
            global::G.DiscussionStateReason? stateReason,
            string title,
            global::System.DateTime updatedAt,
            global::G.DiscussionUser? user,
            global::G.DiscussionReactions? reactions,
            string? timelineUrl,
            global::System.Collections.Generic.IList<global::G.Label>? labels)
        {
            this.ActiveLockReason = activeLockReason ?? throw new global::System.ArgumentNullException(nameof(activeLockReason));
            this.AnswerChosenAt = answerChosenAt ?? throw new global::System.ArgumentNullException(nameof(answerChosenAt));
            this.AnswerChosenBy = answerChosenBy ?? throw new global::System.ArgumentNullException(nameof(answerChosenBy));
            this.AnswerHtmlUrl = answerHtmlUrl ?? throw new global::System.ArgumentNullException(nameof(answerHtmlUrl));
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Comments = comments;
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Locked = locked;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.State = state;
            this.StateReason = stateReason;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Reactions = reactions;
            this.TimelineUrl = timelineUrl;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discussion" /> class.
        /// </summary>
        public Discussion()
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
        public static global::G.Discussion? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Discussion),
                jsonSerializerContext) as global::G.Discussion;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Discussion? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Discussion>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Discussion?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Discussion),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Discussion;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Discussion?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Discussion?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}