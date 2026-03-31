//HintName: G.Models.PostServiceTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostServiceTokenRequest
    {
        /// <summary>
        /// Name of the service token. Does not have to be unique
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the Service token belongs in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// The service account ID this service token should belong to. You can create a service account in the Braintrust [organization settings page](https://www.braintrustdata.com/app/settings?subroute=service-tokens) or using the [modify organization membership endpoint](https://www.braintrust.dev/docs/api-reference/organizations/modify-organization-membership)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostServiceTokenRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the service token. Does not have to be unique
        /// </param>
        /// <param name="serviceAccountId">
        /// The service account ID this service token should belong to. You can create a service account in the Braintrust [organization settings page](https://www.braintrustdata.com/app/settings?subroute=service-tokens) or using the [modify organization membership endpoint](https://www.braintrust.dev/docs/api-reference/organizations/modify-organization-membership)
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the Service token belongs in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostServiceTokenRequest(
            string name,
            string serviceAccountId,
            string? orgName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrgName = orgName;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostServiceTokenRequest" /> class.
        /// </summary>
        public PostServiceTokenRequest()
        {
        }
    }
}