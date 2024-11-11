//HintName: G.Models.Codespace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A codespace.
    /// </summary>
    public sealed partial class Codespace
    {
        /// <summary>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Automatically generated name of this codespace.<br/>
        /// Example: monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        /// <example>monalisa-octocat-hello-world-g4wpq6h95q</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Display name for this codespace.<br/>
        /// Example: bookish space pancake
        /// </summary>
        /// <example>bookish space pancake</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// UUID identifying this codespace's environment.<br/>
        /// Example: 26a7c758-7299-4a73-b978-5a92a7ae98a0
        /// </summary>
        /// <example>26a7c758-7299-4a73-b978-5a92a7ae98a0</example>
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
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

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
        /// <example>.devcontainer/example/devcontainer.json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("devcontainer_path")]
        public string? DevcontainerPath { get; set; }

        /// <summary>
        /// Whether the codespace was created from a prebuild.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
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
        /// <example>Available</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodespaceStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespaceState State { get; set; }

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
        public required global::G.CodespaceGitStatus GitStatus { get; set; }

        /// <summary>
        /// The initally assigned location of a new codespace.<br/>
        /// Example: WestUs2
        /// </summary>
        /// <example>WestUs2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodespaceLocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespaceLocation Location { get; set; }

        /// <summary>
        /// The number of minutes of inactivity after which this codespace will be automatically stopped.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
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
        public global::G.CodespaceRuntimeConstraints? RuntimeConstraints { get; set; }

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
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_period_minutes")]
        public int? RetentionPeriodMinutes { get; set; }

        /// <summary>
        /// When a codespace will be auto-deleted based on the "retention_period_minutes" and "last_used_at"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_expires_at")]
        public global::System.DateTime? RetentionExpiresAt { get; set; }

        /// <summary>
        /// The text to display to a user when a codespace has been stopped for a potentially actionable reason.<br/>
        /// Example: you've used 100% of your spending limit for Codespaces
        /// </summary>
        /// <example>you've used 100% of your spending limit for Codespaces</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_known_stop_notice")]
        public string? LastKnownStopNotice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Codespace" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1L
        /// </param>
        /// <param name="name">
        /// Automatically generated name of this codespace.<br/>
        /// Example: monalisa-octocat-hello-world-g4wpq6h95q
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace.<br/>
        /// Example: bookish space pancake
        /// </param>
        /// <param name="environmentId">
        /// UUID identifying this codespace's environment.<br/>
        /// Example: 26a7c758-7299-4a73-b978-5a92a7ae98a0
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="billableOwner">
        /// A GitHub user.
        /// </param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="machine">
        /// A description of the machine powering a codespace.
        /// </param>
        /// <param name="devcontainerPath">
        /// Path to devcontainer.json from repo root used to create Codespace.<br/>
        /// Example: .devcontainer/example/devcontainer.json
        /// </param>
        /// <param name="prebuild">
        /// Whether the codespace was created from a prebuild.<br/>
        /// Example: false
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt">
        /// Last known time this codespace was started.
        /// </param>
        /// <param name="state">
        /// State of this codespace.<br/>
        /// Example: Available
        /// </param>
        /// <param name="url">
        /// API URL for this codespace.
        /// </param>
        /// <param name="gitStatus">
        /// Details about the codespace's git repository.
        /// </param>
        /// <param name="location">
        /// The initally assigned location of a new codespace.<br/>
        /// Example: WestUs2
        /// </param>
        /// <param name="idleTimeoutMinutes">
        /// The number of minutes of inactivity after which this codespace will be automatically stopped.<br/>
        /// Example: 60
        /// </param>
        /// <param name="webUrl">
        /// URL to access this codespace on the web.
        /// </param>
        /// <param name="machinesUrl">
        /// API URL to access available alternate machine types for this codespace.
        /// </param>
        /// <param name="startUrl">
        /// API URL to start this codespace.
        /// </param>
        /// <param name="stopUrl">
        /// API URL to stop this codespace.
        /// </param>
        /// <param name="publishUrl">
        /// API URL to publish this codespace to a new repository.
        /// </param>
        /// <param name="pullsUrl">
        /// API URL for the Pull Request associated with this codespace, if any.
        /// </param>
        /// <param name="recentFolders"></param>
        /// <param name="runtimeConstraints"></param>
        /// <param name="pendingOperation">
        /// Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it.
        /// </param>
        /// <param name="pendingOperationDisabledReason">
        /// Text to show user when codespace is disabled by a pending operation
        /// </param>
        /// <param name="idleTimeoutNotice">
        /// Text to show user when codespace idle timeout minutes has been overriden by an organization policy
        /// </param>
        /// <param name="retentionPeriodMinutes">
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).<br/>
        /// Example: 60
        /// </param>
        /// <param name="retentionExpiresAt">
        /// When a codespace will be auto-deleted based on the "retention_period_minutes" and "last_used_at"
        /// </param>
        /// <param name="lastKnownStopNotice">
        /// The text to display to a user when a codespace has been stopped for a potentially actionable reason.<br/>
        /// Example: you've used 100% of your spending limit for Codespaces
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Codespace(
            long id,
            string name,
            string? environmentId,
            global::G.SimpleUser owner,
            global::G.SimpleUser billableOwner,
            global::G.MinimalRepository repository,
            global::G.NullableCodespaceMachine? machine,
            bool? prebuild,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime lastUsedAt,
            global::G.CodespaceState state,
            string url,
            global::G.CodespaceGitStatus gitStatus,
            global::G.CodespaceLocation location,
            int? idleTimeoutMinutes,
            string webUrl,
            string machinesUrl,
            string startUrl,
            string stopUrl,
            string? pullsUrl,
            global::System.Collections.Generic.IList<string> recentFolders,
            string? displayName,
            string? devcontainerPath,
            string? publishUrl,
            global::G.CodespaceRuntimeConstraints? runtimeConstraints,
            bool? pendingOperation,
            string? pendingOperationDisabledReason,
            string? idleTimeoutNotice,
            int? retentionPeriodMinutes,
            global::System.DateTime? retentionExpiresAt,
            string? lastKnownStopNotice)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.BillableOwner = billableOwner ?? throw new global::System.ArgumentNullException(nameof(billableOwner));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Machine = machine ?? throw new global::System.ArgumentNullException(nameof(machine));
            this.Prebuild = prebuild;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastUsedAt = lastUsedAt;
            this.State = state;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GitStatus = gitStatus ?? throw new global::System.ArgumentNullException(nameof(gitStatus));
            this.Location = location;
            this.IdleTimeoutMinutes = idleTimeoutMinutes;
            this.WebUrl = webUrl ?? throw new global::System.ArgumentNullException(nameof(webUrl));
            this.MachinesUrl = machinesUrl ?? throw new global::System.ArgumentNullException(nameof(machinesUrl));
            this.StartUrl = startUrl ?? throw new global::System.ArgumentNullException(nameof(startUrl));
            this.StopUrl = stopUrl ?? throw new global::System.ArgumentNullException(nameof(stopUrl));
            this.PullsUrl = pullsUrl ?? throw new global::System.ArgumentNullException(nameof(pullsUrl));
            this.RecentFolders = recentFolders ?? throw new global::System.ArgumentNullException(nameof(recentFolders));
            this.DisplayName = displayName;
            this.DevcontainerPath = devcontainerPath;
            this.PublishUrl = publishUrl;
            this.RuntimeConstraints = runtimeConstraints;
            this.PendingOperation = pendingOperation;
            this.PendingOperationDisabledReason = pendingOperationDisabledReason;
            this.IdleTimeoutNotice = idleTimeoutNotice;
            this.RetentionPeriodMinutes = retentionPeriodMinutes;
            this.RetentionExpiresAt = retentionExpiresAt;
            this.LastKnownStopNotice = lastKnownStopNotice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Codespace" /> class.
        /// </summary>
        public Codespace()
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
        public static global::G.Codespace? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Codespace),
                jsonSerializerContext) as global::G.Codespace;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Codespace? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Codespace>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Codespace?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Codespace),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Codespace;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Codespace?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Codespace?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}