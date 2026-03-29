//HintName: G.Models.SandboxConfigCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxConfigCreate
    {
        /// <summary>
        /// The configuration for the sandbox.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.LocalSandboxConfig, global::G.E2BSandboxConfig, global::G.ModalSandboxConfig> Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigCreate" /> class.
        /// </summary>
        /// <param name="config">
        /// The configuration for the sandbox.
        /// </param>
        public SandboxConfigCreate(
            global::G.AnyOf<global::G.LocalSandboxConfig, global::G.E2BSandboxConfig, global::G.ModalSandboxConfig> config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigCreate" /> class.
        /// </summary>
        public SandboxConfigCreate()
        {
        }
    }
}