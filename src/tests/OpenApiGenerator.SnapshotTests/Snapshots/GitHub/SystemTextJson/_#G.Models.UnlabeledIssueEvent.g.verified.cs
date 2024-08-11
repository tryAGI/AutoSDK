//HintName: G.Models.UnlabeledIssueEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unlabeled Issue Event
    /// </summary>
    public sealed partial class UnlabeledIssueEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CommitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UnlabeledIssueEventLabel Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}