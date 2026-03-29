//HintName: G.Models.CreateExperimentColumnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentColumnRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputKeys")]
        public global::System.Collections.Generic.IList<string>? InputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersionId")]
        public string? PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypothesisId")]
        public string? HypothesisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentColumnRequest" /> class.
        /// </summary>
        /// <param name="columnType"></param>
        /// <param name="columnName"></param>
        /// <param name="inputKeys"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="hypothesisId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentColumnRequest(
            string columnType,
            string columnName,
            global::System.Collections.Generic.IList<string>? inputKeys,
            string? promptVersionId,
            string? hypothesisId)
        {
            this.InputKeys = inputKeys;
            this.PromptVersionId = promptVersionId;
            this.HypothesisId = hypothesisId;
            this.ColumnType = columnType ?? throw new global::System.ArgumentNullException(nameof(columnType));
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentColumnRequest" /> class.
        /// </summary>
        public CreateExperimentColumnRequest()
        {
        }
    }
}