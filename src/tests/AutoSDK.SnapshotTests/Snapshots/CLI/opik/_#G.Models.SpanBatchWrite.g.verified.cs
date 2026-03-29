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
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SpanWrite> Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanBatchWrite" /> class.
        /// </summary>
        /// <param name="spans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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