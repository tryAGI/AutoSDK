//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CweId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe" /> class.
        /// </summary>
        /// <param name="cweId"></param>
        /// <param name="name"></param>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe(
            string cweId,
            string name)
        {
            this.CweId = cweId ?? throw new global::System.ArgumentNullException(nameof(cweId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe" /> class.
        /// </summary>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryCwe()
        {
        }
    }
}