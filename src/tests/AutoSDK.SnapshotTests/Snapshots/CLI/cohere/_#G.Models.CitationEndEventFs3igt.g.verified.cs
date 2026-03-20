//HintName: G.Models.CitationEndEventFs3igt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationEndEventFs3igt
    {
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
        /// Initializes a new instance of the <see cref="CitationEndEventFs3igt" /> class.
        /// </summary>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CitationEndEventFs3igt(
            int? index)
        {
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationEndEventFs3igt" /> class.
        /// </summary>
        public CitationEndEventFs3igt()
        {
        }
    }
}