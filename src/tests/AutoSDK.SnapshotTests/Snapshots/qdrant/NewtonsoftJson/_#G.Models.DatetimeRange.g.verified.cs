//HintName: G.Models.DatetimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Range filter request
    /// </summary>
    public sealed partial class DatetimeRange
    {
        /// <summary>
        /// point.key &lt; range.lt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public global::System.DateTime? Lt { get; set; }

        /// <summary>
        /// point.key &gt; range.gt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public global::System.DateTime? Gt { get; set; }

        /// <summary>
        /// point.key &gt;= range.gte
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public global::System.DateTime? Gte { get; set; }

        /// <summary>
        /// point.key &lt;= range.lte
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public global::System.DateTime? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeRange" /> class.
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
        public DatetimeRange(
            global::System.DateTime? lt,
            global::System.DateTime? gt,
            global::System.DateTime? gte,
            global::System.DateTime? lte)
        {
            this.Lt = lt;
            this.Gt = gt;
            this.Gte = gte;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeRange" /> class.
        /// </summary>
        public DatetimeRange()
        {
        }
    }
}