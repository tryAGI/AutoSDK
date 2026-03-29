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
        [global::Newtonsoft.Json.JsonProperty("added_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int AddedCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duplicates", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duplicates { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAddCallsRes" /> class.
        /// </summary>
        /// <param name="addedCount"></param>
        /// <param name="duplicates"></param>
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