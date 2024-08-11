//HintName: G.Models.ActionsGenerateRunnerJitconfigForRepoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGenerateRunnerJitconfigForRepoResponse
    {
        /// <summary>
        /// A self hosted runner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Runner? Runner { get; set; } = default!;

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
    }
}