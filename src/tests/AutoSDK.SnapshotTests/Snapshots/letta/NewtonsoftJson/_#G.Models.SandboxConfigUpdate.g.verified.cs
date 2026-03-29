//HintName: G.Models.SandboxConfigUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pydantic model for updating SandboxConfig fields.
    /// </summary>
    public sealed partial class SandboxConfigUpdate
    {
        /// <summary>
        /// The JSON configuration data for the sandbox.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.AnyOf<global::G.LocalSandboxConfig, global::G.E2BSandboxConfig, global::G.ModalSandboxConfig>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigUpdate" /> class.
        /// </summary>
        /// <param name="config">
        /// The JSON configuration data for the sandbox.
        /// </param>
        public SandboxConfigUpdate(
            global::G.AnyOf<global::G.LocalSandboxConfig, global::G.E2BSandboxConfig, global::G.ModalSandboxConfig>? config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigUpdate" /> class.
        /// </summary>
        public SandboxConfigUpdate()
        {
        }
    }
}