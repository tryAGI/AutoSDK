//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCreateForAuthenticatedUserRequestVariant1
    {
        /// <summary>
        /// Repository id for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryId { get; set; } = default!;

        /// <summary>
        /// Git ref (typically a branch name) for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geo")]
        public global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo? Geo { get; set; }

        /// <summary>
        /// IP for location auto-detection when proxying a request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// Machine type to use for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machine")]
        public string? Machine { get; set; }

        /// <summary>
        /// Path to devcontainer.json config to use for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("devcontainer_path")]
        public string? DevcontainerPath { get; set; }

        /// <summary>
        /// Whether to authorize requested permissions from devcontainer.json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_repo_permissions_opt_out")]
        public bool? MultiRepoPermissionsOptOut { get; set; }

        /// <summary>
        /// Working directory for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Time in minutes before codespace stops from inactivity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_timeout_minutes")]
        public int? IdleTimeoutMinutes { get; set; }

        /// <summary>
        /// Display name for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention_period_minutes")]
        public int? RetentionPeriodMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateForAuthenticatedUserRequestVariant1" /> class.
        /// </summary>
        /// <param name="repositoryId">
        /// Repository id for this codespace
        /// </param>
        /// <param name="ref">
        /// Git ref (typically a branch name) for this codespace
        /// </param>
        /// <param name="location">
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </param>
        /// <param name="geo">
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </param>
        /// <param name="clientIp">
        /// IP for location auto-detection when proxying a request
        /// </param>
        /// <param name="machine">
        /// Machine type to use for this codespace
        /// </param>
        /// <param name="devcontainerPath">
        /// Path to devcontainer.json config to use for this codespace
        /// </param>
        /// <param name="multiRepoPermissionsOptOut">
        /// Whether to authorize requested permissions from devcontainer.json
        /// </param>
        /// <param name="workingDirectory">
        /// Working directory for this codespace
        /// </param>
        /// <param name="idleTimeoutMinutes">
        /// Time in minutes before codespace stops from inactivity
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="retentionPeriodMinutes">
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
        /// </param>
        public CodespacesCreateForAuthenticatedUserRequestVariant1(
            int repositoryId,
            string? @ref,
            string? location,
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo? geo,
            string? clientIp,
            string? machine,
            string? devcontainerPath,
            bool? multiRepoPermissionsOptOut,
            string? workingDirectory,
            int? idleTimeoutMinutes,
            string? displayName,
            int? retentionPeriodMinutes)
        {
            this.RepositoryId = repositoryId;
            this.Ref = @ref;
            this.Location = location;
            this.Geo = geo;
            this.ClientIp = clientIp;
            this.Machine = machine;
            this.DevcontainerPath = devcontainerPath;
            this.MultiRepoPermissionsOptOut = multiRepoPermissionsOptOut;
            this.WorkingDirectory = workingDirectory;
            this.IdleTimeoutMinutes = idleTimeoutMinutes;
            this.DisplayName = displayName;
            this.RetentionPeriodMinutes = retentionPeriodMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateForAuthenticatedUserRequestVariant1" /> class.
        /// </summary>
        public CodespacesCreateForAuthenticatedUserRequestVariant1()
        {
        }


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
        public static global::G.CodespacesCreateForAuthenticatedUserRequestVariant1? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1?>(serializer.Deserialize<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1>(jsonReader));
        }

    }
}