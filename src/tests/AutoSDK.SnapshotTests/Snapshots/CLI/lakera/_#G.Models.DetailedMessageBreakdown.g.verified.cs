//HintName: G.Models.DetailedMessageBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedMessageBreakdown
    {
        /// <summary>
        /// Index of the message in the input array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_index")]
        public int? MessageIndex { get; set; }

        /// <summary>
        /// Whether this specific message was flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// Per-category flagging results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::G.Categories? Categories { get; set; }

        /// <summary>
        /// Detailed results for this specific message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.DetectorResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMessageBreakdown" /> class.
        /// </summary>
        /// <param name="messageIndex">
        /// Index of the message in the input array.
        /// </param>
        /// <param name="flagged">
        /// Whether this specific message was flagged.
        /// </param>
        /// <param name="categories">
        /// Per-category flagging results.
        /// </param>
        /// <param name="results">
        /// Detailed results for this specific message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedMessageBreakdown(
            int? messageIndex,
            bool? flagged,
            global::G.Categories? categories,
            global::System.Collections.Generic.IList<global::G.DetectorResult>? results)
        {
            this.MessageIndex = messageIndex;
            this.Flagged = flagged;
            this.Categories = categories;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMessageBreakdown" /> class.
        /// </summary>
        public DetailedMessageBreakdown()
        {
        }
    }
}