//HintName: G.Models.ExperimentTableColumnCell.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentTableColumnCell
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RowIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableColumnCell" /> class.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="id"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="value"></param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentTableColumnCell(
            double rowIndex,
            string id,
            global::G.RecordStringAny? metadata,
            string? value,
            string? requestId)
        {
            this.Metadata = metadata;
            this.Value = value;
            this.RequestId = requestId;
            this.RowIndex = rowIndex;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableColumnCell" /> class.
        /// </summary>
        public ExperimentTableColumnCell()
        {
        }
    }
}