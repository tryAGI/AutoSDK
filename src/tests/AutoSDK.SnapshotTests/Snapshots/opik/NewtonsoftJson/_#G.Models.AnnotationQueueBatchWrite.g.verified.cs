//HintName: G.Models.AnnotationQueueBatchWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Batch of annotation queues to create
    /// </summary>
    public sealed partial class AnnotationQueueBatchWrite
    {
        /// <summary>
        /// List of annotation queues to create
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_queues", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnnotationQueueWrite> AnnotationQueues { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueBatchWrite" /> class.
        /// </summary>
        /// <param name="annotationQueues">
        /// List of annotation queues to create
        /// </param>
        public AnnotationQueueBatchWrite(
            global::System.Collections.Generic.IList<global::G.AnnotationQueueWrite> annotationQueues)
        {
            this.AnnotationQueues = annotationQueues ?? throw new global::System.ArgumentNullException(nameof(annotationQueues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueBatchWrite" /> class.
        /// </summary>
        public AnnotationQueueBatchWrite()
        {
        }
    }
}