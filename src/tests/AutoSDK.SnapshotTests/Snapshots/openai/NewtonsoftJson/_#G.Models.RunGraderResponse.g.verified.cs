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
        [global::Newtonsoft.Json.JsonProperty("reward", Required = global::Newtonsoft.Json.Required.Always)]
        public double Reward { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunGraderResponseMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sub_rewards", Required = global::Newtonsoft.Json.Required.Always)]
        public object SubRewards { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_grader_token_usage_per_model", Required = global::Newtonsoft.Json.Required.Always)]
        public object ModelGraderTokenUsagePerModel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponse" /> class.
        /// </summary>
        /// <param name="reward"></param>
        /// <param name="metadata"></param>
        /// <param name="subRewards"></param>
        /// <param name="modelGraderTokenUsagePerModel"></param>
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