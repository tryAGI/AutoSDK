//HintName: G.Models.ScrollResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of the points read request
    /// </summary>
    public sealed partial class ScrollResult
    {
        /// <summary>
        /// List of retrieved points<br/>
        /// Example: [{"id":40,"payload":{"city":"London","color":"green"},"vector":[0.875,0.140625,0.897599995136261],"shard_key":"region_1"}, {"id":41,"payload":{"city":"Paris","color":"red"},"vector":[0.75,0.640625,0.8945000171661377],"shard_key":"region_1"}]
        /// </summary>
        /// <example>[{"id":40,"payload":{"city":"London","color":"green"},"vector":[0.875,0.140625,0.897599995136261],"shard_key":"region_1"}, {"id":41,"payload":{"city":"Paris","color":"red"},"vector":[0.75,0.640625,0.8945000171661377],"shard_key":"region_1"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Record> Points { get; set; }

        /// <summary>
        /// Offset which should be used to retrieve a next page result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_offset")]
        public global::G.ExtendedPointId? NextPageOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollResult" /> class.
        /// </summary>
        /// <param name="points">
        /// List of retrieved points<br/>
        /// Example: [{"id":40,"payload":{"city":"London","color":"green"},"vector":[0.875,0.140625,0.897599995136261],"shard_key":"region_1"}, {"id":41,"payload":{"city":"Paris","color":"red"},"vector":[0.75,0.640625,0.8945000171661377],"shard_key":"region_1"}]
        /// </param>
        /// <param name="nextPageOffset">
        /// Offset which should be used to retrieve a next page result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrollResult(
            global::System.Collections.Generic.IList<global::G.Record> points,
            global::G.ExtendedPointId? nextPageOffset)
        {
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
            this.NextPageOffset = nextPageOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollResult" /> class.
        /// </summary>
        public ScrollResult()
        {
        }
    }
}