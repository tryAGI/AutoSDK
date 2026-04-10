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
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GraphLinkLabelJsonConverter))]
        public global::G.GraphLinkLabel Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_cell_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int SourceCellId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_cell_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int TargetCellId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphLink" /> class.
        /// </summary>
        /// <param name="label">
        /// GraphLinkLabel.
        /// </param>
        /// <param name="sourceCellId"></param>
        /// <param name="targetCellId"></param>
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