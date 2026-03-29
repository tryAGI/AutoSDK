//HintName: G.Models.ContinuousAnnotationConfigData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContinuousAnnotationConfigData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"CONTINUOUS"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CONTINUOUS";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OptimizationDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizationDirection OptimizationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower_bound")]
        public double? LowerBound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper_bound")]
        public double? UpperBound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousAnnotationConfigData" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="optimizationDirection"></param>
        /// <param name="description"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContinuousAnnotationConfigData(
            string name,
            global::G.OptimizationDirection optimizationDirection,
            string? description,
            double? lowerBound,
            double? upperBound,
            string type = "CONTINUOUS")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.OptimizationDirection = optimizationDirection;
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousAnnotationConfigData" /> class.
        /// </summary>
        public ContinuousAnnotationConfigData()
        {
        }
    }
}