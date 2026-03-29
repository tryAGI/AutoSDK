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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the custom metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Weight for scoring (1-100)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScoreWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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