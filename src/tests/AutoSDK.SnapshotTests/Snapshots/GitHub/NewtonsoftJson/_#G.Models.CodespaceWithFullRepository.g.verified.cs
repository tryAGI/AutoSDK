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
        /// Example: 1L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Automatically generated name of this codespace.<br/>
        /// Example: monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Display name for this codespace.<br/>
        /// Example: bookish space pancake
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// UUID identifying this codespace's environment.<br/>
        /// Example: 26a7c758-7299-4a73-b978-5a92a7ae98a0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? EnvironmentId { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable_owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser BillableOwner { get; set; } = default!;

        /// <summary>
        /// Full Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FullRepository Repository { get; set; } = default!;

        /// <summary>
        /// A description of the machine powering a codespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machine", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCodespaceMachine? Machine { get; set; } = default!;

        /// <summary>
        /// Path to devcontainer.json from repo root used to create Codespace.<br/>
        /// Example: .devcontainer/example/devcontainer.json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("devcontainer_path")]
        public string? DevcontainerPath { get; set; }

        /// <summary>
        /// Whether the codespace was created from a prebuild.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prebuild", Required = global::Newtonsoft.Json.Required.Always)]
        public bool? Prebuild { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Last known time this codespace was started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUsedAt { get; set; } = default!;

        /// <summary>
        /// State of this codespace.<br/>
        /// Example: Available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodespaceWithFullRepositoryState State { get; set; } = default!;

        /// <summary>
        /// API URL for this codespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Details about the codespace's git repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodespaceWithFullRepositoryGitStatus GitStatus { get; set; } = default!;

        /// <summary>
        /// The initally assigned location of a new codespace.<br/>
        /// Example: WestUs2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodespaceWithFullRepositoryLocation Location { get; set; } = default!;

        /// <summary>
        /// The number of minutes of inactivity after which this codespace will be automatically stopped.<br/>
        /// Example: 60
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_timeout_minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int? IdleTimeoutMinutes { get; set; } = default!;

        /// <summary>
        /// URL to access this codespace on the web.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebUrl { get; set; } = default!;

        /// <summary>
        /// API URL to access available alternate machine types for this codespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machines_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MachinesUrl { get; set; } = default!;

        /// <summary>
        /// API URL to start this codespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartUrl { get; set; } = default!;

        /// <summary>
        /// API URL to stop this codespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StopUrl { get; set; } = default!;

        /// <summary>
        /// API URL to publish this codespace to a new repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publish_url")]
        public string? PublishUrl { get; set; }

        /// <summary>
        /// API URL for the Pull Request associated with this codespace, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pulls_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? PullsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recent_folders", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RecentFolders { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runtime_constraints")]
        public global::G.CodespaceWithFullRepositoryRuntimeConstraints? RuntimeConstraints { get; set; }

        /// <summary>
        /// Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_operation")]
        public bool? PendingOperation { get; set; }

        /// <summary>
        /// Text to show user when codespace is disabled by a pending operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_operation_disabled_reason")]
        public string? PendingOperationDisabledReason { get; set; }

        /// <summary>
        /// Text to show user when codespace idle timeout minutes has been overriden by an organization policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_timeout_notice")]
        public string? IdleTimeoutNotice { get; set; }

        /// <summary>
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).<br/>
        /// Example: 60
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention_period_minutes")]
        public int? RetentionPeriodMinutes { get; set; }

        /// <summary>
        /// When a codespace will be auto-deleted based on the "retention_period_minutes" and "last_used_at"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention_expires_at")]
        public global::System.DateTime? RetentionExpiresAt { get; set; }

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
        public static global::G.CodespaceWithFullRepository? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodespaceWithFullRepository>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespaceWithFullRepository?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodespaceWithFullRepository?>(serializer.Deserialize<global::G.CodespaceWithFullRepository>(jsonReader));
        }

    }
}