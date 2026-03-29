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
        [global::Newtonsoft.Json.JsonProperty("inputKeys")]
        public global::System.Collections.Generic.IList<string>? InputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersionId")]
        public string? PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hypothesisId")]
        public string? HypothesisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentColumnRequest" /> class.
        /// </summary>
        /// <param name="columnType"></param>
        /// <param name="columnName"></param>
        /// <param name="inputKeys"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="hypothesisId"></param>
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