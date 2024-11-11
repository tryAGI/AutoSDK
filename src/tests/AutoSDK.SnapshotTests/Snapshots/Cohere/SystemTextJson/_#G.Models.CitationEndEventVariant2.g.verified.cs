//HintName: G.Models.CitationEndEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationEndEventVariant2
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
        /// Initializes a new instance of the <see cref="CitationEndEventVariant2" /> class.
        /// </summary>
        /// <param name="index"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CitationEndEventVariant2(
            int? index)
        {
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationEndEventVariant2" /> class.
        /// </summary>
        public CitationEndEventVariant2()
        {
        }
    }
}