//HintName: G.Models.GetOrganizationSubscriptionAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationSubscriptionAdminResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::G.OrganizationSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationSubscriptionAdminResponse" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetOrganizationSubscriptionAdminResponse(
            global::G.OrganizationSubscription? subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationSubscriptionAdminResponse" /> class.
        /// </summary>
        public GetOrganizationSubscriptionAdminResponse()
        {
        }
    }
}