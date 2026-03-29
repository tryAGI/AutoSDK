//HintName: G.Models.AnnotatorQueueItemsProgressUpdateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from updating annotation state.
    /// </summary>
    public sealed partial class AnnotatorQueueItemsProgressUpdateRes
    {
        /// <summary>
        /// Schema for annotation queue item responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnnotationQueueItemSchema Item { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotatorQueueItemsProgressUpdateRes" /> class.
        /// </summary>
        /// <param name="item">
        /// Schema for annotation queue item responses.
        /// </param>
        public AnnotatorQueueItemsProgressUpdateRes(
            global::G.AnnotationQueueItemSchema item)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotatorQueueItemsProgressUpdateRes" /> class.
        /// </summary>
        public AnnotatorQueueItemsProgressUpdateRes()
        {
        }
    }
}