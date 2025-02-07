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
        [global::System.Text.Json.Serialization.JsonPropertyName("runner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Runner Runner { get; set; }

        /// <summary>
        /// The base64 encoded runner configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded_jit_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncodedJitConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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