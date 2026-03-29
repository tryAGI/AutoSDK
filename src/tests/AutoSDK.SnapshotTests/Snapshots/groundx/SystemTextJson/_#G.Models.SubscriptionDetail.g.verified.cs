//HintName: G.Models.SubscriptionDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Subscription information for the user, including current usage and limits
    /// </summary>
    public sealed partial class SubscriptionDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meters")]
        public global::G.SubscriptionDetailMeters? Meters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetail" /> class.
        /// </summary>
        /// <param name="meters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionDetail(
            global::G.SubscriptionDetailMeters? meters)
        {
            this.Meters = meters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetail" /> class.
        /// </summary>
        public SubscriptionDetail()
        {
        }
    }
}