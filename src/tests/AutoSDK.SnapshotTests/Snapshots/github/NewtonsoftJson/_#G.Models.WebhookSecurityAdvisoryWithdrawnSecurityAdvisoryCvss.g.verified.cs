//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_string")]
        public string? VectorString { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="vectorString"></param>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss(
            double score,
            string? vectorString)
        {
            this.Score = score;
            this.VectorString = vectorString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss" /> class.
        /// </summary>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCvss()
        {
        }
    }
}