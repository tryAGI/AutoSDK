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
        [global::Newtonsoft.Json.JsonProperty("updateInputs")]
        public bool? UpdateInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cellId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CellId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentCellRequest" /> class.
        /// </summary>
        /// <param name="cellId"></param>
        /// <param name="updateInputs"></param>
        /// <param name="metadata"></param>
        /// <param name="value"></param>
        /// <param name="status"></param>
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