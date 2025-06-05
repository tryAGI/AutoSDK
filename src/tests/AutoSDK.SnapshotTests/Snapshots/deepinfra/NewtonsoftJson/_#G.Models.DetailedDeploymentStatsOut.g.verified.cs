//HintName: G.Models.DetailedDeploymentStatsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedDeploymentStatsOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm")]
        public global::G.LLMDeploymentStatsOut? Llm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings")]
        public global::G.EmbeddingsDeploymentStatsOut? Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public global::G.TimeDeploymentStatsOut? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="llm"></param>
        /// <param name="embeddings"></param>
        /// <param name="time"></param>
        public DetailedDeploymentStatsOut(
            global::G.LLMDeploymentStatsOut? llm,
            global::G.EmbeddingsDeploymentStatsOut? embeddings,
            global::G.TimeDeploymentStatsOut? time)
        {
            this.Llm = llm;
            this.Embeddings = embeddings;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedDeploymentStatsOut" /> class.
        /// </summary>
        public DetailedDeploymentStatsOut()
        {
        }
    }
}