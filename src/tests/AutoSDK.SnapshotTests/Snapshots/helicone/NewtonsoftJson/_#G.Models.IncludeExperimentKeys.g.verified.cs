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
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public bool? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersion")]
        public bool? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseBodies")]
        public bool? ResponseBodies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public bool? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IncludeExperimentKeys" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="promptVersion"></param>
        /// <param name="responseBodies"></param>
        /// <param name="score"></param>
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