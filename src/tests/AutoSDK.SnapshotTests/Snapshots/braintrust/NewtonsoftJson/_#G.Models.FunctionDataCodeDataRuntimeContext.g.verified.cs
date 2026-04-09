//HintName: G.Models.FunctionDataCodeDataRuntimeContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataCodeDataRuntimeContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runtime", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeJsonConverter))]
        public global::G.FunctionDataCodeDataRuntimeContextRuntime Runtime { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="FunctionDataCodeDataRuntimeContext" /> class.
        /// </summary>
        /// <param name="runtime"></param>
        /// <param name="version"></param>
        public FunctionDataCodeDataRuntimeContext(
            global::G.FunctionDataCodeDataRuntimeContextRuntime runtime,
            string version)
        {
            this.Runtime = runtime;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataCodeDataRuntimeContext" /> class.
        /// </summary>
        public FunctionDataCodeDataRuntimeContext()
        {
        }
    }
}