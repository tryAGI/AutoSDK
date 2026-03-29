//HintName: G.Models.SandboxDetail.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxDetail
    {
        /// <summary>
        /// Identifier of the template from which is the sandbox created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxID { get; set; }

        /// <summary>
        /// Identifier of the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientID { get; set; }

        /// <summary>
        /// Time when the sandbox was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Time when the sandbox will expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndAt { get; set; }

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvdVersion { get; set; }

        /// <summary>
        /// Access token used for envd communication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdAccessToken")]
        public string? EnvdAccessToken { get; set; }

        /// <summary>
        /// Whether internet access was explicitly enabled or disabled for the sandbox. Null means it was not explicitly set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowInternetAccess")]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// Base domain where the sandbox traffic is accessible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryMB { get; set; }

        /// <summary>
        /// Disk size for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskSizeMB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DiskSizeMB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// State of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SandboxStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SandboxState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::G.SandboxNetworkConfig? Network { get; set; }

        /// <summary>
        /// Sandbox lifecycle policy returned by sandbox info.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        public global::G.SandboxLifecycle? Lifecycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeMounts")]
        public global::System.Collections.Generic.IList<global::G.SandboxVolumeMount>? VolumeMounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxDetail" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template from which is the sandbox created
        /// </param>
        /// <param name="sandboxID">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="clientID">
        /// Identifier of the client
        /// </param>
        /// <param name="startedAt">
        /// Time when the sandbox was started
        /// </param>
        /// <param name="endAt">
        /// Time when the sandbox will expire
        /// </param>
        /// <param name="envdVersion">
        /// Version of the envd running in the sandbox
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="diskSizeMB">
        /// Disk size for the sandbox in MiB
        /// </param>
        /// <param name="state">
        /// State of the sandbox
        /// </param>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="envdAccessToken">
        /// Access token used for envd communication
        /// </param>
        /// <param name="allowInternetAccess">
        /// Whether internet access was explicitly enabled or disabled for the sandbox. Null means it was not explicitly set.
        /// </param>
        /// <param name="domain">
        /// Base domain where the sandbox traffic is accessible
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="network"></param>
        /// <param name="lifecycle">
        /// Sandbox lifecycle policy returned by sandbox info.
        /// </param>
        /// <param name="volumeMounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxDetail(
            string templateID,
            string sandboxID,
            string clientID,
            global::System.DateTime startedAt,
            global::System.DateTime endAt,
            string envdVersion,
            int cpuCount,
            int memoryMB,
            int diskSizeMB,
            global::G.SandboxState state,
            string? alias,
            string? envdAccessToken,
            bool? allowInternetAccess,
            string? domain,
            object? metadata,
            global::G.SandboxNetworkConfig? network,
            global::G.SandboxLifecycle? lifecycle,
            global::System.Collections.Generic.IList<global::G.SandboxVolumeMount>? volumeMounts)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Alias = alias;
            this.SandboxID = sandboxID ?? throw new global::System.ArgumentNullException(nameof(sandboxID));
            this.ClientID = clientID ?? throw new global::System.ArgumentNullException(nameof(clientID));
            this.StartedAt = startedAt;
            this.EndAt = endAt;
            this.EnvdVersion = envdVersion ?? throw new global::System.ArgumentNullException(nameof(envdVersion));
            this.EnvdAccessToken = envdAccessToken;
            this.AllowInternetAccess = allowInternetAccess;
            this.Domain = domain;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
            this.DiskSizeMB = diskSizeMB;
            this.Metadata = metadata;
            this.State = state;
            this.Network = network;
            this.Lifecycle = lifecycle;
            this.VolumeMounts = volumeMounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxDetail" /> class.
        /// </summary>
        public SandboxDetail()
        {
        }
    }
}