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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnnotationQueueItemSchema> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsQueryRes" /> class.
        /// </summary>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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