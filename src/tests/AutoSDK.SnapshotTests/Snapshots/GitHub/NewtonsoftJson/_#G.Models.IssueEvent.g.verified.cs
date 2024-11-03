//HintName: G.Models.IssueEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event
    /// </summary>
    public sealed partial class IssueEvent
    {
        /// <summary>
        /// Example: 1L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOklzc3VlRXZlbnQx
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Actor { get; set; } = default!;

        /// <summary>
        /// Example: closed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue")]
        public global::G.NullableIssue? Issue { get; set; }

        /// <summary>
        /// Issue Event Label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public global::G.IssueEventLabel? Label { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee")]
        public global::G.NullableSimpleUser? Assignee { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigner")]
        public global::G.NullableSimpleUser? Assigner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_requester")]
        public global::G.NullableSimpleUser? ReviewRequester { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_reviewer")]
        public global::G.NullableSimpleUser? RequestedReviewer { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_team")]
        public global::G.Team? RequestedTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_review")]
        public global::G.IssueEventDismissedReview? DismissedReview { get; set; }

        /// <summary>
        /// Issue Event Milestone
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone")]
        public global::G.IssueEventMilestone? Milestone { get; set; }

        /// <summary>
        /// Issue Event Project Card
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_card")]
        public global::G.IssueEventProjectCard? ProjectCard { get; set; }

        /// <summary>
        /// Issue Event Rename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rename")]
        public global::G.IssueEventRename? Rename { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association")]
        public global::G.AuthorAssociation? AuthorAssociation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_reason")]
        public string? LockReason { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

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
        public static global::G.IssueEvent? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.IssueEvent>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.IssueEvent?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.IssueEvent?>(serializer.Deserialize<global::G.IssueEvent>(jsonReader));
        }

    }
}