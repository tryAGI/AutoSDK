//HintName: G.Models.ValuesCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Values count filter request
    /// </summary>
    public sealed partial class ValuesCount
    {
        /// <summary>
        /// point.key.length() &lt; values_count.lt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public int? Lt { get; set; }

        /// <summary>
        /// point.key.length() &gt; values_count.gt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public int? Gt { get; set; }

        /// <summary>
        /// point.key.length() &gt;= values_count.gte
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public int? Gte { get; set; }

        /// <summary>
        /// point.key.length() &lt;= values_count.lte
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public int? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesCount" /> class.
        /// </summary>
        /// <param name="lt">
        /// point.key.length() &lt; values_count.lt
        /// </param>
        /// <param name="gt">
        /// point.key.length() &gt; values_count.gt
        /// </param>
        /// <param name="gte">
        /// point.key.length() &gt;= values_count.gte
        /// </param>
        /// <param name="lte">
        /// point.key.length() &lt;= values_count.lte
        /// </param>
        public ValuesCount(
            int? lt,
            int? gt,
            int? gte,
            int? lte)
        {
            this.Lt = lt;
            this.Gt = gt;
            this.Gte = gte;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesCount" /> class.
        /// </summary>
        public ValuesCount()
        {
        }
    }
}