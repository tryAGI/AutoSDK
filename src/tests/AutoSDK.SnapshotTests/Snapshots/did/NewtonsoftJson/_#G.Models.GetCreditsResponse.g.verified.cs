//HintName: G.Models.GetCreditsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCreditsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetCreditsResponseCredit> Credits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining", Required = global::Newtonsoft.Json.Required.Always)]
        public double Remaining { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponse" /> class.
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="remaining"></param>
        /// <param name="total"></param>
        public GetCreditsResponse(
            global::System.Collections.Generic.IList<global::G.GetCreditsResponseCredit> credits,
            double remaining,
            double total)
        {
            this.Credits = credits ?? throw new global::System.ArgumentNullException(nameof(credits));
            this.Remaining = remaining;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponse" /> class.
        /// </summary>
        public GetCreditsResponse()
        {
        }
    }
}