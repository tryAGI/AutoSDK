//HintName: G.Models.ActionsGenerateRunnerJitconfigForOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGenerateRunnerJitconfigForOrgResponse
    {
        /// <summary>
        /// A self hosted runner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Runner Runner { get; set; } = default!;

        /// <summary>
        /// The base64 encoded runner configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoded_jit_config", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncodedJitConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForOrgResponse" /> class.
        /// </summary>
        /// <param name="runner">
        /// A self hosted runner
        /// </param>
        /// <param name="encodedJitConfig">
        /// The base64 encoded runner configuration.
        /// </param>
        public ActionsGenerateRunnerJitconfigForOrgResponse(
            global::G.Runner runner,
            string encodedJitConfig)
        {
            this.Runner = runner ?? throw new global::System.ArgumentNullException(nameof(runner));
            this.EncodedJitConfig = encodedJitConfig ?? throw new global::System.ArgumentNullException(nameof(encodedJitConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForOrgResponse" /> class.
        /// </summary>
        public ActionsGenerateRunnerJitconfigForOrgResponse()
        {
        }
    }
}