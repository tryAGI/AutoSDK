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
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueSizeSchema" /> class.
        /// </summary>
        /// <param name="size"></param>
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