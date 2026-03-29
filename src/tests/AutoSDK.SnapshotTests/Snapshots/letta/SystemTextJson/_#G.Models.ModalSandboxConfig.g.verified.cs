//HintName: G.Models.ModalSandboxConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModalSandboxConfig
    {
        /// <summary>
        /// Time limit for the sandbox (in seconds).<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// A list of pip packages to install in the Modal sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pip_requirements")]
        public global::System.Collections.Generic.IList<string>? PipRequirements { get; set; }

        /// <summary>
        /// A list of npm packages to install in the Modal sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm_requirements")]
        public global::System.Collections.Generic.IList<string>? NpmRequirements { get; set; }

        /// <summary>
        /// Default Value: python
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModalSandboxConfigLanguageJsonConverter))]
        public global::G.ModalSandboxConfigLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalSandboxConfig" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Time limit for the sandbox (in seconds).<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="pipRequirements">
        /// A list of pip packages to install in the Modal sandbox
        /// </param>
        /// <param name="npmRequirements">
        /// A list of npm packages to install in the Modal sandbox
        /// </param>
        /// <param name="language">
        /// Default Value: python
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModalSandboxConfig(
            int? timeout,
            global::System.Collections.Generic.IList<string>? pipRequirements,
            global::System.Collections.Generic.IList<string>? npmRequirements,
            global::G.ModalSandboxConfigLanguage? language)
        {
            this.Timeout = timeout;
            this.PipRequirements = pipRequirements;
            this.NpmRequirements = npmRequirements;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalSandboxConfig" /> class.
        /// </summary>
        public ModalSandboxConfig()
        {
        }
    }
}