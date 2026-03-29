//HintName: G.Models.CustomMetricCriteria.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomMetricCriteria
    {
        /// <summary>
        /// Name of the custom metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the custom metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Weight for scoring (1-100)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScoreWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetricCriteria" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the custom metric
        /// </param>
        /// <param name="description">
        /// Description of the custom metric
        /// </param>
        /// <param name="scoreWeight">
        /// Weight for scoring (1-100)
        /// </param>
        public CustomMetricCriteria(
            string name,
            string description,
            double scoreWeight)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ScoreWeight = scoreWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetricCriteria" /> class.
        /// </summary>
        public CustomMetricCriteria()
        {
        }
    }
}