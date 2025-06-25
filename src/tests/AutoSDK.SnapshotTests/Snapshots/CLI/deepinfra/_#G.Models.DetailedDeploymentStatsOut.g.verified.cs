﻿//HintName: G.Models.DetailedDeploymentStatsOut.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::G.LLMDeploymentStatsOut? Llm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::G.EmbeddingsDeploymentStatsOut? Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::G.TimeDeploymentStatsOut? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="llm"></param>
        /// <param name="embeddings"></param>
        /// <param name="time"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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