//HintName: G.Models.SandboxNetworkConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxNetworkConfig
    {
        /// <summary>
        /// Specify if the sandbox URLs should be accessible only with authentication.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowPublicTraffic")]
        public bool? AllowPublicTraffic { get; set; }

        /// <summary>
        /// List of allowed CIDR blocks or IP addresses for egress traffic. Allowed addresses always take precedence over blocked addresses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowOut")]
        public global::System.Collections.Generic.IList<string>? AllowOut { get; set; }

        /// <summary>
        /// List of denied CIDR blocks or IP addresses for egress traffic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("denyOut")]
        public global::System.Collections.Generic.IList<string>? DenyOut { get; set; }

        /// <summary>
        /// Specify host mask which will be used for all sandbox requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskRequestHost")]
        public string? MaskRequestHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkConfig" /> class.
        /// </summary>
        /// <param name="allowPublicTraffic">
        /// Specify if the sandbox URLs should be accessible only with authentication.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowOut">
        /// List of allowed CIDR blocks or IP addresses for egress traffic. Allowed addresses always take precedence over blocked addresses.
        /// </param>
        /// <param name="denyOut">
        /// List of denied CIDR blocks or IP addresses for egress traffic
        /// </param>
        /// <param name="maskRequestHost">
        /// Specify host mask which will be used for all sandbox requests
        /// </param>
        public SandboxNetworkConfig(
            bool? allowPublicTraffic,
            global::System.Collections.Generic.IList<string>? allowOut,
            global::System.Collections.Generic.IList<string>? denyOut,
            string? maskRequestHost)
        {
            this.AllowPublicTraffic = allowPublicTraffic;
            this.AllowOut = allowOut;
            this.DenyOut = denyOut;
            this.MaskRequestHost = maskRequestHost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkConfig" /> class.
        /// </summary>
        public SandboxNetworkConfig()
        {
        }
    }
}