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
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HistoryAlignmentResponseModel Alignment { get; set; }

        /// <summary>
        /// The normalized alignment of the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HistoryAlignmentResponseModel NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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