//HintName: G.Models.PromptOptimizationJobCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("algorithm", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EPromptOptimizationAlgorithm Algorithm { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobCreate" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        public PromptOptimizationJobCreate(
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config)
        {
            this.Algorithm = algorithm;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobCreate" /> class.
        /// </summary>
        public PromptOptimizationJobCreate()
        {
        }
    }
}