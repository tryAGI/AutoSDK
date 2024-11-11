//HintName: G.Models.WhereFilterGeoRangeDistance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhereFilterGeoRangeDistance
    {
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
        /// Initializes a new instance of the <see cref="WhereFilterGeoRangeDistance" /> class.
        /// </summary>
        /// <param name="max"></param>
        public WhereFilterGeoRangeDistance(
            double? max)
        {
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilterGeoRangeDistance" /> class.
        /// </summary>
        public WhereFilterGeoRangeDistance()
        {
        }
    }
}