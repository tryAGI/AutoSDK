//HintName: G.Models.RunGraderResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reward")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Reward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunGraderResponseMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_rewards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object SubRewards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_grader_token_usage_per_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ModelGraderTokenUsagePerModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponse" /> class.
        /// </summary>
        /// <param name="reward"></param>
        /// <param name="metadata"></param>
        /// <param name="subRewards"></param>
        /// <param name="modelGraderTokenUsagePerModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGraderResponse(
            double reward,
            global::G.RunGraderResponseMetadata metadata,
            object subRewards,
            object modelGraderTokenUsagePerModel)
        {
            this.Reward = reward;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SubRewards = subRewards ?? throw new global::System.ArgumentNullException(nameof(subRewards));
            this.ModelGraderTokenUsagePerModel = modelGraderTokenUsagePerModel ?? throw new global::System.ArgumentNullException(nameof(modelGraderTokenUsagePerModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponse" /> class.
        /// </summary>
        public RunGraderResponse()
        {
        }
    }
}