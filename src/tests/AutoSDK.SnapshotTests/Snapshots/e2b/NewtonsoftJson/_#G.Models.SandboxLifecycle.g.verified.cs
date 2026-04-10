//HintName: G.Models.SandboxLifecycle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sandbox lifecycle policy returned by sandbox info.
    /// </summary>
    public sealed partial class SandboxLifecycle
    {
        /// <summary>
        /// Whether the sandbox can auto-resume.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoResume", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutoResume { get; set; } = default!;

        /// <summary>
        /// Action taken when the sandbox times out.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onTimeout", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SandboxOnTimeoutJsonConverter))]
        public global::G.SandboxOnTimeout OnTimeout { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLifecycle" /> class.
        /// </summary>
        /// <param name="autoResume">
        /// Whether the sandbox can auto-resume.
        /// </param>
        /// <param name="onTimeout">
        /// Action taken when the sandbox times out.
        /// </param>
        public SandboxLifecycle(
            bool autoResume,
            global::G.SandboxOnTimeout onTimeout)
        {
            this.AutoResume = autoResume;
            this.OnTimeout = onTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLifecycle" /> class.
        /// </summary>
        public SandboxLifecycle()
        {
        }
    }
}