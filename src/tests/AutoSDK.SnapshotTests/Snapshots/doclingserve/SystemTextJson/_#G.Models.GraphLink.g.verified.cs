//HintName: G.Models.GraphLink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphLink.
    /// </summary>
    public sealed partial class GraphLink
    {
        /// <summary>
        /// GraphLinkLabel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphLinkLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphLinkLabel Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_cell_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SourceCellId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_cell_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetCellId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphLink" /> class.
        /// </summary>
        /// <param name="label">
        /// GraphLinkLabel.
        /// </param>
        /// <param name="sourceCellId"></param>
        /// <param name="targetCellId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphLink(
            global::G.GraphLinkLabel label,
            int sourceCellId,
            int targetCellId)
        {
            this.Label = label;
            this.SourceCellId = sourceCellId;
            this.TargetCellId = targetCellId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphLink" /> class.
        /// </summary>
        public GraphLink()
        {
        }
    }
}