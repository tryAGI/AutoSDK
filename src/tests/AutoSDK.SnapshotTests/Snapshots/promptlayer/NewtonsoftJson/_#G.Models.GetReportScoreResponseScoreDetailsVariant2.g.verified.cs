//HintName: G.Models.GetReportScoreResponseScoreDetailsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Multi-column score details
    /// </summary>
    public sealed partial class GetReportScoreResponseScoreDetailsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns")]
        public global::System.Collections.Generic.IList<global::G.GetReportScoreResponseScoreDetailsVariant2Column>? Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant2" /> class.
        /// </summary>
        /// <param name="columns"></param>
        public GetReportScoreResponseScoreDetailsVariant2(
            global::System.Collections.Generic.IList<global::G.GetReportScoreResponseScoreDetailsVariant2Column>? columns)
        {
            this.Columns = columns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant2" /> class.
        /// </summary>
        public GetReportScoreResponseScoreDetailsVariant2()
        {
        }
    }
}