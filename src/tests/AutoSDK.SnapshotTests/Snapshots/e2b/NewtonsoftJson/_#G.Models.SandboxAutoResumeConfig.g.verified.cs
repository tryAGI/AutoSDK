//HintName: G.Models.SandboxAutoResumeConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Auto-resume configuration for paused sandboxes.
    /// </summary>
    public sealed partial class SandboxAutoResumeConfig
    {
        /// <summary>
        /// Auto-resume enabled flag for paused sandboxes. Default false.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxAutoResumeConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Auto-resume enabled flag for paused sandboxes. Default false.<br/>
        /// Default Value: false
        /// </param>
        public SandboxAutoResumeConfig(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxAutoResumeConfig" /> class.
        /// </summary>
        public SandboxAutoResumeConfig()
        {
        }
    }
}