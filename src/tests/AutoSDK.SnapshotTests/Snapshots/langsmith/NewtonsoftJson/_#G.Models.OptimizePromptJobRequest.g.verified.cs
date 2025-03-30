//HintName: G.Models.OptimizePromptJobRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to optimize a prompt.
    /// </summary>
    public sealed partial class OptimizePromptJobRequest
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptJobRequest" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="promptName"></param>
        public OptimizePromptJobRequest(
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config,
            string promptName)
        {
            this.Algorithm = algorithm;
            this.Config = config;
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptJobRequest" /> class.
        /// </summary>
        public OptimizePromptJobRequest()
        {
        }
    }
}