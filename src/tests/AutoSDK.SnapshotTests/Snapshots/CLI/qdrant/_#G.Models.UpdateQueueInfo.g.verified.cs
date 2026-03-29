//HintName: G.Models.UpdateQueueInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateQueueInfo
    {
        /// <summary>
        /// Number of elements in the queue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Length { get; set; }

        /// <summary>
        /// Number of points that are deferred (i.e hidden from search as they're not yet optimized).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred_points")]
        public int? DeferredPoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateQueueInfo" /> class.
        /// </summary>
        /// <param name="length">
        /// Number of elements in the queue
        /// </param>
        /// <param name="deferredPoints">
        /// Number of points that are deferred (i.e hidden from search as they're not yet optimized).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateQueueInfo(
            int length,
            int? deferredPoints)
        {
            this.Length = length;
            this.DeferredPoints = deferredPoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateQueueInfo" /> class.
        /// </summary>
        public UpdateQueueInfo()
        {
        }
    }
}