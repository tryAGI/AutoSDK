//HintName: G.Models.LocalSandboxConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalSandboxConfig
    {
        /// <summary>
        /// Directory for the sandbox environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_dir")]
        public string? SandboxDir { get; set; }

        /// <summary>
        /// Whether or not to use the venv, or run directly in the same run loop.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_venv")]
        public bool? UseVenv { get; set; }

        /// <summary>
        /// The name for the venv in the sandbox directory. We first search for an existing venv with this name, otherwise, we make it from the requirements.txt.<br/>
        /// Default Value: venv
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("venv_name")]
        public string? VenvName { get; set; }

        /// <summary>
        /// List of pip packages to install with mandatory name and optional version following semantic versioning. This only is considered when use_venv is True.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pip_requirements")]
        public global::System.Collections.Generic.IList<global::G.PipRequirement>? PipRequirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalSandboxConfig" /> class.
        /// </summary>
        /// <param name="sandboxDir">
        /// Directory for the sandbox environment.
        /// </param>
        /// <param name="useVenv">
        /// Whether or not to use the venv, or run directly in the same run loop.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="venvName">
        /// The name for the venv in the sandbox directory. We first search for an existing venv with this name, otherwise, we make it from the requirements.txt.<br/>
        /// Default Value: venv
        /// </param>
        /// <param name="pipRequirements">
        /// List of pip packages to install with mandatory name and optional version following semantic versioning. This only is considered when use_venv is True.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalSandboxConfig(
            string? sandboxDir,
            bool? useVenv,
            string? venvName,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements)
        {
            this.SandboxDir = sandboxDir;
            this.UseVenv = useVenv;
            this.VenvName = venvName;
            this.PipRequirements = pipRequirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalSandboxConfig" /> class.
        /// </summary>
        public LocalSandboxConfig()
        {
        }
    }
}