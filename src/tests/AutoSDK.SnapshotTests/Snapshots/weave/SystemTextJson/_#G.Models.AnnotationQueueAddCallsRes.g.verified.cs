//HintName: G.Models.AnnotationQueueAddCallsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from adding calls to a queue.
    /// </summary>
    public sealed partial class AnnotationQueueAddCallsRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AddedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duplicates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAddCallsRes" /> class.
        /// </summary>
        /// <param name="addedCount"></param>
        /// <param name="duplicates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueAddCallsRes(
            int addedCount,
            int duplicates)
        {
            this.AddedCount = addedCount;
            this.Duplicates = duplicates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAddCallsRes" /> class.
        /// </summary>
        public AnnotationQueueAddCallsRes()
        {
        }
    }
}