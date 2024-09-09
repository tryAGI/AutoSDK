//HintName: G.Models.CodespaceWithFullRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A codespace.
    /// </summary>
    public sealed partial class CodespaceWithFullRepository
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Automatically generated name of this codespace.<br/>
        /// Example: monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Display name for this codespace.<br/>
        /// Example: bookish space pancake
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// UUID identifying this codespace's environment.<br/>
        /// Example: 26a7c758-7299-4a73-b978-5a92a7ae98a0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? EnvironmentId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Owner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser BillableOwner { get; set; }

        /// <summary>
        /// Full Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FullRepository Repository { get; set; }

        /// <summary>
        /// A description of the machine powering a codespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableCodespaceMachine? Machine { get; set; }

        /// <summary>
        /// Path to devcontainer.json from repo root used to create Codespace.<br/>
        /// Example: .devcontainer/example/devcontainer.json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devcontainer_path")]
        public string? DevcontainerPath { get; set; }

        /// <summary>
        /// Whether the codespace was created from a prebuild.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuild")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? Prebuild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Last known time this codespace was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUsedAt { get; set; }

        /// <summary>
        /// State of this codespace.<br/>
        /// Example: Available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.CodespaceWithFullRepositoryStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespaceWithFullRepositoryState State { get; set; }

        /// <summary>
        /// API URL for this codespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Details about the codespace's git repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespaceWithFullRepositoryGitStatus GitStatus { get; set; }

        /// <summary>
        /// The initally assigned location of a new codespace.<br/>
        /// Example: WestUs2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.CodespaceWithFullRepositoryLocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespaceWithFullRepositoryLocation Location { get; set; }

        /// <summary>
        /// The number of minutes of inactivity after which this codespace will be automatically stopped.<br/>
        /// Example: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? IdleTimeoutMinutes { get; set; }

        /// <summary>
        /// URL to access this codespace on the web.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebUrl { get; set; }

        /// <summary>
        /// API URL to access available alternate machine types for this codespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machines_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MachinesUrl { get; set; }

        /// <summary>
        /// API URL to start this codespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartUrl { get; set; }

        /// <summary>
        /// API URL to stop this codespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StopUrl { get; set; }

        /// <summary>
        /// API URL to publish this codespace to a new repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publish_url")]
        public string? PublishUrl { get; set; }

        /// <summary>
        /// API URL for the Pull Request associated with this codespace, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PullsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_folders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RecentFolders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_constraints")]
        public global::G.CodespaceWithFullRepositoryRuntimeConstraints? RuntimeConstraints { get; set; }

        /// <summary>
        /// Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_operation")]
        public bool? PendingOperation { get; set; }

        /// <summary>
        /// Text to show user when codespace is disabled by a pending operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_operation_disabled_reason")]
        public string? PendingOperationDisabledReason { get; set; }

        /// <summary>
        /// Text to show user when codespace idle timeout minutes has been overriden by an organization policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_notice")]
        public string? IdleTimeoutNotice { get; set; }

        /// <summary>
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).<br/>
        /// Example: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_period_minutes")]
        public int? RetentionPeriodMinutes { get; set; }

        /// <summary>
        /// When a codespace will be auto-deleted based on the "retention_period_minutes" and "last_used_at"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_expires_at")]
        public global::System.DateTime? RetentionExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}