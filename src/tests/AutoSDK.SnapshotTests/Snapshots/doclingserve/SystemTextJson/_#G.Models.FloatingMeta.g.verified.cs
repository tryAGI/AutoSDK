//HintName: G.Models.FloatingMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata model for floating.
    /// </summary>
    public sealed partial class FloatingMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::G.SummaryMetaField? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::G.DescriptionMetaField? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingMeta" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FloatingMeta(
            global::G.SummaryMetaField? summary,
            global::G.DescriptionMetaField? description)
        {
            this.Summary = summary;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingMeta" /> class.
        /// </summary>
        public FloatingMeta()
        {
        }
    }
}