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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"CONTINUOUS"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "CONTINUOUS";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimization_direction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OptimizationDirection OptimizationDirection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lower_bound")]
        public double? LowerBound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upper_bound")]
        public double? UpperBound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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