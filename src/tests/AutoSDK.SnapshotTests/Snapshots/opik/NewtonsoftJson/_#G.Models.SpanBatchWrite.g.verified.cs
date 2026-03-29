//HintName: G.Models.SpanBatchWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanBatchWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SpanWrite> Spans { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanBatchWrite" /> class.
        /// </summary>
        /// <param name="spans"></param>
        public SpanBatchWrite(
            global::System.Collections.Generic.IList<global::G.SpanWrite> spans)
        {
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanBatchWrite" /> class.
        /// </summary>
        public SpanBatchWrite()
        {
        }
    }
}