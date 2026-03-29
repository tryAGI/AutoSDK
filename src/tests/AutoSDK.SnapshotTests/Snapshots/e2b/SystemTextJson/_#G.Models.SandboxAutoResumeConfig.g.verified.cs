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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxAutoResumeConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Auto-resume enabled flag for paused sandboxes. Default false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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