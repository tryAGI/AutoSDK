//HintName: G.Models.CodespacesCreateWithPrForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCreateWithPrForAuthenticatedUserRequest
    {
        /// <summary>
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodespacesCreateWithPrForAuthenticatedUserRequestGeoJsonConverter))]
        public CodespacesCreateWithPrForAuthenticatedUserRequestGeo? Geo { get; set; }

        /// <summary>
        /// IP for location auto-detection when proxying a request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// Machine type to use for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine")]
        public string? Machine { get; set; }

        /// <summary>
        /// Path to devcontainer.json config to use for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devcontainer_path")]
        public string? DevcontainerPath { get; set; }

        /// <summary>
        /// Whether to authorize requested permissions from devcontainer.json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_repo_permissions_opt_out")]
        public bool MultiRepoPermissionsOptOut { get; set; }

        /// <summary>
        /// Working directory for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Time in minutes before codespace stops from inactivity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_minutes")]
        public int IdleTimeoutMinutes { get; set; }

        /// <summary>
        /// Display name for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_period_minutes")]
        public int RetentionPeriodMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}