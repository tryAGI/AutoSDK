//HintName: G.Models.AnnotationQueueItemsQueryRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from querying annotation queue items.
    /// </summary>
    public sealed partial class AnnotationQueueItemsQueryRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnnotationQueueItemSchema> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsQueryRes" /> class.
        /// </summary>
        /// <param name="items"></param>
        public AnnotationQueueItemsQueryRes(
            global::System.Collections.Generic.IList<global::G.AnnotationQueueItemSchema> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsQueryRes" /> class.
        /// </summary>
        public AnnotationQueueItemsQueryRes()
        {
        }
    }
}