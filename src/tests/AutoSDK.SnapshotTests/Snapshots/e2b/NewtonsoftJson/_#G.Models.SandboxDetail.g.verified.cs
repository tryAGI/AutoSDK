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
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandboxID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SandboxID { get; set; } = default!;

        /// <summary>
        /// Identifier of the client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientID", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientID { get; set; } = default!;

        /// <summary>
        /// Time when the sandbox was started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// Time when the sandbox will expire
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndAt { get; set; } = default!;

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envdVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnvdVersion { get; set; } = default!;

        /// <summary>
        /// Access token used for envd communication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envdAccessToken")]
        public string? EnvdAccessToken { get; set; }

        /// <summary>
        /// Whether internet access was explicitly enabled or disabled for the sandbox. Null means it was not explicitly set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowInternetAccess")]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// Base domain where the sandbox traffic is accessible
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int CpuCount { get; set; } = default!;

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryMB", Required = global::Newtonsoft.Json.Required.Always)]
        public int MemoryMB { get; set; } = default!;

        /// <summary>
        /// Disk size for the sandbox in MiB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diskSizeMB", Required = global::Newtonsoft.Json.Required.Always)]
        public int DiskSizeMB { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// State of the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SandboxState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("network")]
        public global::G.SandboxNetworkConfig? Network { get; set; }

        /// <summary>
        /// Sandbox lifecycle policy returned by sandbox info.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lifecycle")]
        public global::G.SandboxLifecycle? Lifecycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volumeMounts")]
        public global::System.Collections.Generic.IList<global::G.SandboxVolumeMount>? VolumeMounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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