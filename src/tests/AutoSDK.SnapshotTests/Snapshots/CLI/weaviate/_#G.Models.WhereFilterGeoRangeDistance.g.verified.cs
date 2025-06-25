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
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilterGeoRangeDistance" /> class.
        /// </summary>
        /// <param name="max"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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