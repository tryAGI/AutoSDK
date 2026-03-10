//HintName: G.Models.ReadLegalTerms.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadLegalTerms
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms")]
        public string? Terms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadLegalTerms" /> class.
        /// </summary>
        /// <param name="terms"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public ReadLegalTerms(
            string? terms,
            string? startDate,
            string? endDate)
        {
            this.Terms = terms;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadLegalTerms" /> class.
        /// </summary>
        public ReadLegalTerms()
        {
        }
    }
}