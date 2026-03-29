//HintName: G.Models.UpdateExperimentCellRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExperimentCellRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateInputs")]
        public bool? UpdateInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cellId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CellId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentCellRequest" /> class.
        /// </summary>
        /// <param name="cellId"></param>
        /// <param name="updateInputs"></param>
        /// <param name="metadata"></param>
        /// <param name="value"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateExperimentCellRequest(
            string cellId,
            bool? updateInputs,
            string? metadata,
            string? value,
            string? status)
        {
            this.UpdateInputs = updateInputs;
            this.Metadata = metadata;
            this.Value = value;
            this.Status = status;
            this.CellId = cellId ?? throw new global::System.ArgumentNullException(nameof(cellId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentCellRequest" /> class.
        /// </summary>
        public UpdateExperimentCellRequest()
        {
        }
    }
}