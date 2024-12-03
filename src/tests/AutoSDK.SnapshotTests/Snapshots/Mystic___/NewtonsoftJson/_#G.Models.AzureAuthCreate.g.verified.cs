//HintName: G.Models.AzureAuthCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class AzureAuthCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureAuthCreate" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tenantId"></param>
        /// <param name="subscriptionId"></param>
        public AzureAuthCreate(
            string clientId,
            string clientSecret,
            string tenantId,
            string subscriptionId)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.SubscriptionId = subscriptionId ?? throw new global::System.ArgumentNullException(nameof(subscriptionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureAuthCreate" /> class.
        /// </summary>
        public AzureAuthCreate()
        {
        }
    }
}