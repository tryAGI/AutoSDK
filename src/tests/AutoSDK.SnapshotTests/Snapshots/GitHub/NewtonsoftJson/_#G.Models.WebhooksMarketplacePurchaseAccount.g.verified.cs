//HintName: G.Models.WebhooksMarketplacePurchaseAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksMarketplacePurchaseAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_billing_email", Required = global::Newtonsoft.Json.Required.Always)]
        public string? OrganizationBillingEmail { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMarketplacePurchaseAccount" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="nodeId"></param>
        /// <param name="organizationBillingEmail"></param>
        /// <param name="type"></param>
        public WebhooksMarketplacePurchaseAccount(
            int id,
            string login,
            string nodeId,
            string? organizationBillingEmail,
            string type)
        {
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.OrganizationBillingEmail = organizationBillingEmail ?? throw new global::System.ArgumentNullException(nameof(organizationBillingEmail));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMarketplacePurchaseAccount" /> class.
        /// </summary>
        public WebhooksMarketplacePurchaseAccount()
        {
        }
    }
}