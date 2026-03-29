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
        [global::Newtonsoft.Json.JsonProperty("updated_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double UpdatedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateAllSubscriptionsCronResponse" /> class.
        /// </summary>
        /// <param name="updatedCount"></param>
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