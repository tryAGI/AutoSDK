//HintName: G.Models.ListPipelineTriggerChartRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineTriggerChartRecordsResponse contains a list of pipeline trigger<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListPipelineTriggerChartRecordsResponse
    {
        /// <summary>
        /// A list of pipeline trigger records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTriggerChartRecords")]
        public global::System.Collections.Generic.IList<global::G.PipelineTriggerChartRecord>? PipelineTriggerChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerChartRecordsResponse" /> class.
        /// </summary>
        /// <param name="pipelineTriggerChartRecords">
        /// A list of pipeline trigger records.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListPipelineTriggerChartRecordsResponse(
            global::System.Collections.Generic.IList<global::G.PipelineTriggerChartRecord>? pipelineTriggerChartRecords)
        {
            this.PipelineTriggerChartRecords = pipelineTriggerChartRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerChartRecordsResponse" /> class.
        /// </summary>
        public ListPipelineTriggerChartRecordsResponse()
        {
        }
    }
}