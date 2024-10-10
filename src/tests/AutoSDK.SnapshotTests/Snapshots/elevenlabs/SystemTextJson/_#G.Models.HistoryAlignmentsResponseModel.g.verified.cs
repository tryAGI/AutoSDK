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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HistoryAlignmentResponseModel Alignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HistoryAlignmentResponseModel NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}