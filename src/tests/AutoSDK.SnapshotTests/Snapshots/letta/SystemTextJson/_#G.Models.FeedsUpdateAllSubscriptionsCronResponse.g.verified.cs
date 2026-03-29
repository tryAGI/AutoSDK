//HintName: G.Models.FeedsUpdateAllSubscriptionsCronResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsUpdateAllSubscriptionsCronResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateAllSubscriptionsCronResponse" /> class.
        /// </summary>
        /// <param name="updatedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsUpdateAllSubscriptionsCronResponse(
            double updatedCount)
        {
            this.UpdatedCount = updatedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateAllSubscriptionsCronResponse" /> class.
        /// </summary>
        public FeedsUpdateAllSubscriptionsCronResponse()
        {
        }
    }
}