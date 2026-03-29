//HintName: G.Models.AnnotationQueueReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from reading an annotation queue.
    /// </summary>
    public sealed partial class AnnotationQueueReadRes
    {
        /// <summary>
        /// Schema for annotation queue responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnnotationQueueSchema Queue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueReadRes" /> class.
        /// </summary>
        /// <param name="queue">
        /// Schema for annotation queue responses.
        /// </param>
        public AnnotationQueueReadRes(
            global::G.AnnotationQueueSchema queue)
        {
            this.Queue = queue ?? throw new global::System.ArgumentNullException(nameof(queue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueReadRes" /> class.
        /// </summary>
        public AnnotationQueueReadRes()
        {
        }
    }
}