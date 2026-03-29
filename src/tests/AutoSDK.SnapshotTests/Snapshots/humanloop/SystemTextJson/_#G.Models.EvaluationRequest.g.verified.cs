//HintName: G.Models.EvaluationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an Evaluation.
    /// </summary>
    public sealed partial class EvaluationRequest
    {
        /// <summary>
        /// ID of the File to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// Name of the Evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// IDs of Evaluators to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorIds")]
        public global::System.Collections.Generic.IList<string>? EvaluatorIds { get; set; }

        /// <summary>
        /// ID of the Dataset to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the File to evaluate.
        /// </param>
        /// <param name="name">
        /// Name of the Evaluation.
        /// </param>
        /// <param name="evaluatorIds">
        /// IDs of Evaluators to use.
        /// </param>
        /// <param name="datasetId">
        /// ID of the Dataset to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRequest(
            string? fileId,
            string? name,
            global::System.Collections.Generic.IList<string>? evaluatorIds,
            string? datasetId)
        {
            this.FileId = fileId;
            this.Name = name;
            this.EvaluatorIds = evaluatorIds;
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRequest" /> class.
        /// </summary>
        public EvaluationRequest()
        {
        }
    }
}