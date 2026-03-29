//HintName: G.Models.CreateDatasetVersionFromFilterParamsRequestScores2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequestScores2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min")]
        public double? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestScores2" /> class.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public CreateDatasetVersionFromFilterParamsRequestScores2(
            double? min,
            double? max)
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestScores2" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequestScores2()
        {
        }
    }
}