//HintName: G.Models.SubscriptionDetailMeters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionDetailMeters
    {
        /// <summary>
        /// Current usage and limits for the user for the given metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileTokens")]
        public global::G.MeterDetail? FileTokens { get; set; }

        /// <summary>
        /// Current usage and limits for the user for the given metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        public global::G.MeterDetail? Searches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetailMeters" /> class.
        /// </summary>
        /// <param name="fileTokens">
        /// Current usage and limits for the user for the given metric
        /// </param>
        /// <param name="searches">
        /// Current usage and limits for the user for the given metric
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionDetailMeters(
            global::G.MeterDetail? fileTokens,
            global::G.MeterDetail? searches)
        {
            this.FileTokens = fileTokens;
            this.Searches = searches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetailMeters" /> class.
        /// </summary>
        public SubscriptionDetailMeters()
        {
        }
    }
}