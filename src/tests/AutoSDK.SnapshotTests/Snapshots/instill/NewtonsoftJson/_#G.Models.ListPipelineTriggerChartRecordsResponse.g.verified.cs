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
        [global::Newtonsoft.Json.JsonProperty("pipelineTriggerChartRecords")]
        public global::System.Collections.Generic.IList<global::G.PipelineTriggerChartRecord>? PipelineTriggerChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}