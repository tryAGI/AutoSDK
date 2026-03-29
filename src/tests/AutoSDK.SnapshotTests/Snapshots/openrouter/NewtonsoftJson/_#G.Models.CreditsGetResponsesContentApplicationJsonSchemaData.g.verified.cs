//HintName: G.Models.CreditsGetResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsGetResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Total credits purchased
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_credits", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCredits { get; set; } = default!;

        /// <summary>
        /// Total credits used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalUsage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="totalCredits">
        /// Total credits purchased
        /// </param>
        /// <param name="totalUsage">
        /// Total credits used
        /// </param>
        public CreditsGetResponsesContentApplicationJsonSchemaData(
            double totalCredits,
            double totalUsage)
        {
            this.TotalCredits = totalCredits;
            this.TotalUsage = totalUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public CreditsGetResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}