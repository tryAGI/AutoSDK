﻿//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCreateForAuthenticatedUserRequestVariant2
    {
        /// <summary>
        /// Pull request number for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest PullRequest { get; set; }

        /// <summary>
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodespacesCreateForAuthenticatedUserRequestVariant2GeoJsonConverter))]
        public global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo? Geo { get; set; }

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
        /// Working directory for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Time in minutes before codespace stops from inactivity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_minutes")]
        public int? IdleTimeoutMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateForAuthenticatedUserRequestVariant2" /> class.
        /// </summary>
        /// <param name="pullRequest">
        /// Pull request number for this codespace
        /// </param>
        /// <param name="location">
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </param>
        /// <param name="geo">
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </param>
        /// <param name="machine">
        /// Machine type to use for this codespace
        /// </param>
        /// <param name="devcontainerPath">
        /// Path to devcontainer.json config to use for this codespace
        /// </param>
        /// <param name="workingDirectory">
        /// Working directory for this codespace
        /// </param>
        /// <param name="idleTimeoutMinutes">
        /// Time in minutes before codespace stops from inactivity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesCreateForAuthenticatedUserRequestVariant2(
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant2PullRequest pullRequest,
            string? location,
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo? geo,
            string? machine,
            string? devcontainerPath,
            string? workingDirectory,
            int? idleTimeoutMinutes)
        {
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Location = location;
            this.Geo = geo;
            this.Machine = machine;
            this.DevcontainerPath = devcontainerPath;
            this.WorkingDirectory = workingDirectory;
            this.IdleTimeoutMinutes = idleTimeoutMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCreateForAuthenticatedUserRequestVariant2" /> class.
        /// </summary>
        public CodespacesCreateForAuthenticatedUserRequestVariant2()
        {
        }
    }
}