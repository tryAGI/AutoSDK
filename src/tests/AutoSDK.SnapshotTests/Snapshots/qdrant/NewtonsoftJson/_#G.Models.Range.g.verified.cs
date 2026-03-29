//HintName: G.Models.Range.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Range filter request
    /// </summary>
    public sealed partial class Range
    {
        /// <summary>
        /// point.key &lt; range.lt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public double? Lt { get; set; }

        /// <summary>
        /// point.key &gt; range.gt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public double? Gt { get; set; }

        /// <summary>
        /// point.key &gt;= range.gte
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public double? Gte { get; set; }

        /// <summary>
        /// point.key &lt;= range.lte
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public double? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="lt">
        /// point.key &lt; range.lt
        /// </param>
        /// <param name="gt">
        /// point.key &gt; range.gt
        /// </param>
        /// <param name="gte">
        /// point.key &gt;= range.gte
        /// </param>
        /// <param name="lte">
        /// point.key &lt;= range.lte
        /// </param>
        public Range(
            double? lt,
            double? gt,
            double? gte,
            double? lte)
        {
            this.Lt = lt;
            this.Gt = gt;
            this.Gte = gte;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        public Range()
        {
        }
    }
}