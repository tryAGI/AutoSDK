//HintName: G.Models.ResultSuccessTableIdStringExperimentIdStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessTableIdStringExperimentIdStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTableIdStringExperimentIdStringData" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="tableId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessTableIdStringExperimentIdStringData(
            string experimentId,
            string tableId)
        {
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
            this.TableId = tableId ?? throw new global::System.ArgumentNullException(nameof(tableId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessTableIdStringExperimentIdStringData" /> class.
        /// </summary>
        public ResultSuccessTableIdStringExperimentIdStringData()
        {
        }
    }
}