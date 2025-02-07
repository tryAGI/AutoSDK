//HintName: G.Models.AnnotationQueueSizeSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Size of an Annotation Queue
    /// </summary>
    public sealed partial class AnnotationQueueSizeSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueSizeSchema" /> class.
        /// </summary>
        /// <param name="size"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueSizeSchema(
            int size)
        {
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueSizeSchema" /> class.
        /// </summary>
        public AnnotationQueueSizeSchema()
        {
        }
    }
}