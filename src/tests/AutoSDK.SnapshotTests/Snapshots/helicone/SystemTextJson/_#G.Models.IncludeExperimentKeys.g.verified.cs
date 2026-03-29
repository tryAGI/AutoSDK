//HintName: G.Models.IncludeExperimentKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IncludeExperimentKeys
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public bool? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public bool? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBodies")]
        public bool? ResponseBodies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public bool? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IncludeExperimentKeys" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="promptVersion"></param>
        /// <param name="responseBodies"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IncludeExperimentKeys(
            bool? inputs,
            bool? promptVersion,
            bool? responseBodies,
            bool? score)
        {
            this.Inputs = inputs;
            this.PromptVersion = promptVersion;
            this.ResponseBodies = responseBodies;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncludeExperimentKeys" /> class.
        /// </summary>
        public IncludeExperimentKeys()
        {
        }
    }
}