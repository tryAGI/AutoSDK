//HintName: G.Models.GetAuthenticatedUserSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetAuthenticatedUserSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetAuthenticatedUserSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::G.UserSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthenticatedUserSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="subscription">
        /// The subscription resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthenticatedUserSubscriptionResponse(
            global::G.UserSubscription? subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthenticatedUserSubscriptionResponse" /> class.
        /// </summary>
        public GetAuthenticatedUserSubscriptionResponse()
        {
        }
    }
}