//HintName: G.Models.AnnotationQueueBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Batch of annotation queues to create
    /// </summary>
    public sealed partial class AnnotationQueueBatch
    {
        /// <summary>
        /// List of annotation queues to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_queues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnnotationQueue> AnnotationQueues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueBatch" /> class.
        /// </summary>
        /// <param name="annotationQueues">
        /// List of annotation queues to create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueBatch(
            global::System.Collections.Generic.IList<global::G.AnnotationQueue> annotationQueues)
        {
            this.AnnotationQueues = annotationQueues ?? throw new global::System.ArgumentNullException(nameof(annotationQueues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueBatch" /> class.
        /// </summary>
        public AnnotationQueueBatch()
        {
        }
    }
}