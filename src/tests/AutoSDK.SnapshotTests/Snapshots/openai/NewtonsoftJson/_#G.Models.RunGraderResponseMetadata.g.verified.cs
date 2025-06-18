//HintName: G.Models.RunGraderResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunGraderResponseMetadataErrors Errors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double ExecutionTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public object Scores { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public int? TokenUsage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampled_model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SampledModelName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponseMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="errors"></param>
        /// <param name="executionTime"></param>
        /// <param name="scores"></param>
        /// <param name="tokenUsage"></param>
        /// <param name="sampledModelName"></param>
        public RunGraderResponseMetadata(
            string name,
            string type,
            global::G.RunGraderResponseMetadataErrors errors,
            double executionTime,
            object scores,
            int? tokenUsage,
            string? sampledModelName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.ExecutionTime = executionTime;
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.TokenUsage = tokenUsage;
            this.SampledModelName = sampledModelName ?? throw new global::System.ArgumentNullException(nameof(sampledModelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponseMetadata" /> class.
        /// </summary>
        public RunGraderResponseMetadata()
        {
        }
    }
}