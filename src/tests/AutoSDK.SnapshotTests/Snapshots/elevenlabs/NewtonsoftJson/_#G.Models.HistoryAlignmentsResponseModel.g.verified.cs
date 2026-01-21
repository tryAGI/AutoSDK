//HintName: G.Models.HistoryAlignmentsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoryAlignmentsResponseModel
    {
        /// <summary>
        /// The alignment of the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alignment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HistoryAlignmentResponseModel Alignment { get; set; } = default!;

        /// <summary>
        /// The normalized alignment of the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized_alignment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HistoryAlignmentResponseModel NormalizedAlignment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryAlignmentsResponseModel" /> class.
        /// </summary>
        /// <param name="alignment">
        /// The alignment of the text.
        /// </param>
        /// <param name="normalizedAlignment">
        /// The normalized alignment of the text.
        /// </param>
        public HistoryAlignmentsResponseModel(
            global::G.HistoryAlignmentResponseModel alignment,
            global::G.HistoryAlignmentResponseModel normalizedAlignment)
        {
            this.Alignment = alignment ?? throw new global::System.ArgumentNullException(nameof(alignment));
            this.NormalizedAlignment = normalizedAlignment ?? throw new global::System.ArgumentNullException(nameof(normalizedAlignment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryAlignmentsResponseModel" /> class.
        /// </summary>
        public HistoryAlignmentsResponseModel()
        {
        }
    }
}