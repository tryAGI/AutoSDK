//HintName: G.Models.NewSandbox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewSandbox
    {
        /// <summary>
        /// Identifier of the required template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Automatically pauses the sandbox after the timeout<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoPause")]
        public bool? AutoPause { get; set; }

        /// <summary>
        /// Auto-resume configuration for paused sandboxes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoResume")]
        public global::G.SandboxAutoResumeConfig? AutoResume { get; set; }

        /// <summary>
        /// Secure all system communication with sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secure")]
        public bool? Secure { get; set; }

        /// <summary>
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_internet_access")]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::G.SandboxNetworkConfig? Network { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVars")]
        public object? EnvVars { get; set; }

        /// <summary>
        /// MCP configuration for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        public global::G.Mcp? Mcp { get; set; }

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
        /// Initializes a new instance of the <see cref="NewSandbox" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the required template
        /// </param>
        /// <param name="timeout">
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="autoPause">
        /// Automatically pauses the sandbox after the timeout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoResume">
        /// Auto-resume configuration for paused sandboxes.
        /// </param>
        /// <param name="secure">
        /// Secure all system communication with sandbox
        /// </param>
        /// <param name="allowInternetAccess">
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </param>
        /// <param name="network"></param>
        /// <param name="metadata"></param>
        /// <param name="envVars"></param>
        /// <param name="mcp">
        /// MCP configuration for the sandbox
        /// </param>
        /// <param name="volumeMounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewSandbox(
            string templateID,
            int? timeout,
            bool? autoPause,
            global::G.SandboxAutoResumeConfig? autoResume,
            bool? secure,
            bool? allowInternetAccess,
            global::G.SandboxNetworkConfig? network,
            object? metadata,
            object? envVars,
            global::G.Mcp? mcp,
            global::System.Collections.Generic.IList<global::G.SandboxVolumeMount>? volumeMounts)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Timeout = timeout;
            this.AutoPause = autoPause;
            this.AutoResume = autoResume;
            this.Secure = secure;
            this.AllowInternetAccess = allowInternetAccess;
            this.Network = network;
            this.Metadata = metadata;
            this.EnvVars = envVars;
            this.Mcp = mcp;
            this.VolumeMounts = volumeMounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewSandbox" /> class.
        /// </summary>
        public NewSandbox()
        {
        }
    }
}