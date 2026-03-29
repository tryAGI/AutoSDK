//HintName: G.Models.CreateOrgDTO.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrgDTO
    {
        /// <summary>
        /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false.<br/>
        /// When HIPAA is enabled, only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively.<br/>
        /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("hipaaEnabled")]
        public bool? HipaaEnabled { get; set; }

        /// <summary>
        /// This is the ID of the subscription the org belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptionId")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// This is the name of the org. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        public global::G.CreateOrgDTOChannel? Channel { get; set; }

        /// <summary>
        /// This is the monthly billing limit for the org. To go beyond $1000/mo, please contact us at support@vapi.ai.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billingLimit")]
        public double? BillingLimit { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// This is the concurrency limit for the org. This is the maximum number of calls that can be active at any given time. To go beyond 10, please contact us at support@vapi.ai.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concurrencyLimit")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? ConcurrencyLimit { get; set; }

        /// <summary>
        /// Stores the information about the compliance plan enforced at the organization level. Currently pciEnabled is supported through this field.<br/>
        /// When this is enabled, any logs, recordings, or transcriptions will be shipped to the customer endpoints if provided else lost.<br/>
        /// At the end of the call, you will receive an end-of-call-report message to store on your server, if webhook is provided.<br/>
        /// Defaults to false.<br/>
        /// When PCI is enabled, only PCI-compliant Providers will be available for LLM, Voice and transcribers.<br/>
        /// This is due to the compliance requirements of PCI. Other providers may not meet these requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compliancePlan")]
        public global::G.CompliancePlan? CompliancePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgDTO" /> class.
        /// </summary>
        /// <param name="hipaaEnabled">
        /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false.<br/>
        /// When HIPAA is enabled, only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively.<br/>
        /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.<br/>
        /// Example: false
        /// </param>
        /// <param name="subscriptionId">
        /// This is the ID of the subscription the org belongs to.
        /// </param>
        /// <param name="name">
        /// This is the name of the org. This is just for your own reference.
        /// </param>
        /// <param name="channel">
        /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
        /// </param>
        /// <param name="billingLimit">
        /// This is the monthly billing limit for the org. To go beyond $1000/mo, please contact us at support@vapi.ai.
        /// </param>
        /// <param name="server">
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </param>
        /// <param name="compliancePlan">
        /// Stores the information about the compliance plan enforced at the organization level. Currently pciEnabled is supported through this field.<br/>
        /// When this is enabled, any logs, recordings, or transcriptions will be shipped to the customer endpoints if provided else lost.<br/>
        /// At the end of the call, you will receive an end-of-call-report message to store on your server, if webhook is provided.<br/>
        /// Defaults to false.<br/>
        /// When PCI is enabled, only PCI-compliant Providers will be available for LLM, Voice and transcribers.<br/>
        /// This is due to the compliance requirements of PCI. Other providers may not meet these requirements.
        /// </param>
        public CreateOrgDTO(
            bool? hipaaEnabled,
            string? subscriptionId,
            string? name,
            global::G.CreateOrgDTOChannel? channel,
            double? billingLimit,
            global::G.Server? server,
            global::G.CompliancePlan? compliancePlan)
        {
            this.HipaaEnabled = hipaaEnabled;
            this.SubscriptionId = subscriptionId;
            this.Name = name;
            this.Channel = channel;
            this.BillingLimit = billingLimit;
            this.Server = server;
            this.CompliancePlan = compliancePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgDTO" /> class.
        /// </summary>
        public CreateOrgDTO()
        {
        }
    }
}