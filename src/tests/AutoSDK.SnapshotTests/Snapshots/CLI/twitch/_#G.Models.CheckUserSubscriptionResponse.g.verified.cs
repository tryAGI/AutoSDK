//HintName: G.Models.CheckUserSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckUserSubscriptionResponse
    {
        /// <summary>
        /// A list that contains a single object with information about the user’s subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UserSubscription> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUserSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with information about the user’s subscription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckUserSubscriptionResponse(
            global::System.Collections.Generic.IList<global::G.UserSubscription> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUserSubscriptionResponse" /> class.
        /// </summary>
        public CheckUserSubscriptionResponse()
        {
        }
    }
}