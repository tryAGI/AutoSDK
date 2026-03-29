//HintName: G.Models.AnnotationQueueUpdateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from updating an annotation queue.
    /// </summary>
    public sealed partial class AnnotationQueueUpdateRes
    {
        /// <summary>
        /// Schema for annotation queue responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnnotationQueueSchema Queue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateRes" /> class.
        /// </summary>
        /// <param name="queue">
        /// Schema for annotation queue responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueUpdateRes(
            global::G.AnnotationQueueSchema queue)
        {
            this.Queue = queue ?? throw new global::System.ArgumentNullException(nameof(queue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateRes" /> class.
        /// </summary>
        public AnnotationQueueUpdateRes()
        {
        }
    }
}