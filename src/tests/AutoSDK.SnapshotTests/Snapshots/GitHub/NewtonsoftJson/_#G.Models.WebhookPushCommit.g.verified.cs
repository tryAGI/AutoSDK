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
        [global::Newtonsoft.Json.JsonProperty("added")]
        public global::System.Collections.Generic.IList<string>? Added { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPushCommitAuthor Author { get; set; } = default!;

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPushCommitCommitter Committer { get; set; } = default!;

        /// <summary>
        /// Whether this commit is distinct from any that have been pushed before.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distinct", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Distinct { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// An array of files modified by the commit. A maximum of 3000 changed files will be reported per commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified")]
        public global::System.Collections.Generic.IList<string>? Modified { get; set; }

        /// <summary>
        /// An array of files removed in the commit. A maximum of 3000 changed files will be reported per commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removed")]
        public global::System.Collections.Generic.IList<string>? Removed { get; set; }

        /// <summary>
        /// The ISO 8601 timestamp of the commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreeId { get; set; } = default!;

        /// <summary>
        /// URL that points to the commit API resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.WebhookPushCommit? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPushCommit>(
                json,
                jsonSerializerOptions);
        }

    }
}