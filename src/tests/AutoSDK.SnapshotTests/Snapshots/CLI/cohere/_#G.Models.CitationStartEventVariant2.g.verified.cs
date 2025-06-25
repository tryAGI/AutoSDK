//HintName: G.Models.CitationStartEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationStartEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::G.CitationStartEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationStartEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CitationStartEventVariant2(
            global::G.CitationStartEventVariant2Delta? delta,
            int? index)
        {
            this.Delta = delta;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationStartEventVariant2" /> class.
        /// </summary>
        public CitationStartEventVariant2()
        {
        }
    }
}