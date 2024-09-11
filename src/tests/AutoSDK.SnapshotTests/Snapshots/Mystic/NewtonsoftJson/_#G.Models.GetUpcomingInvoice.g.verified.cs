//HintName: G.Models.GetUpcomingInvoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a customer's upcoming invoice, including free credit usage in<br/>
    /// cents and billing period
    /// </summary>
    public sealed partial class GetUpcomingInvoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreditsUsed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_total", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreditsTotal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_date", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_date", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndDate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}