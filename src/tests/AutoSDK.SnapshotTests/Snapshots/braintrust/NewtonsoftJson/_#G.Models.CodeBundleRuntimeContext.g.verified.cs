//HintName: G.Models.CodeBundleRuntimeContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleRuntimeContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runtime", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeBundleRuntimeContextRuntime Runtime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleRuntimeContext" /> class.
        /// </summary>
        /// <param name="runtime"></param>
        /// <param name="version"></param>
        public CodeBundleRuntimeContext(
            global::G.CodeBundleRuntimeContextRuntime runtime,
            string version)
        {
            this.Runtime = runtime;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleRuntimeContext" /> class.
        /// </summary>
        public CodeBundleRuntimeContext()
        {
        }
    }
}