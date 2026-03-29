//HintName: G.Models.E2BSandboxConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class E2BSandboxConfig
    {
        /// <summary>
        /// Time limit for the sandbox (in seconds).<br/>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// The E2B template id (docker image).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public string? Template { get; set; }

        /// <summary>
        /// A list of pip packages to install on the E2B Sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pip_requirements")]
        public global::System.Collections.Generic.IList<string>? PipRequirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="E2BSandboxConfig" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Time limit for the sandbox (in seconds).<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="template">
        /// The E2B template id (docker image).
        /// </param>
        /// <param name="pipRequirements">
        /// A list of pip packages to install on the E2B Sandbox
        /// </param>
        public E2BSandboxConfig(
            int? timeout,
            string? template,
            global::System.Collections.Generic.IList<string>? pipRequirements)
        {
            this.Timeout = timeout;
            this.Template = template;
            this.PipRequirements = pipRequirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="E2BSandboxConfig" /> class.
        /// </summary>
        public E2BSandboxConfig()
        {
        }
    }
}