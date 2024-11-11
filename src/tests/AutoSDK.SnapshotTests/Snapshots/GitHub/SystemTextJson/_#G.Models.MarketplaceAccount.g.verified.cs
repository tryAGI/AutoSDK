//HintName: G.Models.MarketplaceAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplaceAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_billing_email")]
        public string? OrganizationBillingEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceAccount" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="nodeId"></param>
        /// <param name="login"></param>
        /// <param name="email"></param>
        /// <param name="organizationBillingEmail"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MarketplaceAccount(
            string url,
            int id,
            string type,
            string login,
            string? nodeId,
            string? email,
            string? organizationBillingEmail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.NodeId = nodeId;
            this.Email = email;
            this.OrganizationBillingEmail = organizationBillingEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceAccount" /> class.
        /// </summary>
        public MarketplaceAccount()
        {
        }
    }
}