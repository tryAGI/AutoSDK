//HintName: G.Models.WebhookPushCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPushCommit
    {
        /// <summary>
        /// An array of files added in the commit. A maximum of 3000 changed files will be reported per commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        public global::System.Collections.Generic.IList<string>? Added { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushCommitAuthor Author { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPushCommitCommitter Committer { get; set; }

        /// <summary>
        /// Whether this commit is distinct from any that have been pushed before.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Distinct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// An array of files modified by the commit. A maximum of 3000 changed files will be reported per commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        public global::System.Collections.Generic.IList<string>? Modified { get; set; }

        /// <summary>
        /// An array of files removed in the commit. A maximum of 3000 changed files will be reported per commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        public global::System.Collections.Generic.IList<string>? Removed { get; set; }

        /// <summary>
        /// The ISO 8601 timestamp of the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreeId { get; set; }

        /// <summary>
        /// URL that points to the commit API resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPushCommit" /> class.
        /// </summary>
        /// <param name="added">
        /// An array of files added in the commit. A maximum of 3000 changed files will be reported per commit.
        /// </param>
        /// <param name="author">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="distinct">
        /// Whether this commit is distinct from any that have been pushed before.
        /// </param>
        /// <param name="id"></param>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="modified">
        /// An array of files modified by the commit. A maximum of 3000 changed files will be reported per commit.
        /// </param>
        /// <param name="removed">
        /// An array of files removed in the commit. A maximum of 3000 changed files will be reported per commit.
        /// </param>
        /// <param name="timestamp">
        /// The ISO 8601 timestamp of the commit.
        /// </param>
        /// <param name="treeId"></param>
        /// <param name="url">
        /// URL that points to the commit API resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPushCommit(
            global::G.WebhookPushCommitAuthor author,
            global::G.WebhookPushCommitCommitter committer,
            bool distinct,
            string id,
            string message,
            global::System.DateTime timestamp,
            string treeId,
            string url,
            global::System.Collections.Generic.IList<string>? added,
            global::System.Collections.Generic.IList<string>? modified,
            global::System.Collections.Generic.IList<string>? removed)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Distinct = distinct;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp;
            this.TreeId = treeId ?? throw new global::System.ArgumentNullException(nameof(treeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Added = added;
            this.Modified = modified;
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPushCommit" /> class.
        /// </summary>
        public WebhookPushCommit()
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
        public static global::G.WebhookPushCommit? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookPushCommit),
                jsonSerializerContext) as global::G.WebhookPushCommit;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookPushCommit? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookPushCommit>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookPushCommit?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookPushCommit),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookPushCommit;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPushCommit?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookPushCommit?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}