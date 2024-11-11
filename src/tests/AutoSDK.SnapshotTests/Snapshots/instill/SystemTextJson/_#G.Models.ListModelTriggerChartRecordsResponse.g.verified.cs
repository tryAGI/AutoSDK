//HintName: G.Models.ListModelTriggerChartRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListModelTriggerChartRecordsResponse contains a list of model trigger<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListModelTriggerChartRecordsResponse
    {
        /// <summary>
        /// Model trigger counts. Until we allow filtering or grouping by fields<br/>
        /// like model ID, this list will contain only one element with the<br/>
        /// timeline of trigger counts for a given requester, regardless the model<br/>
        /// ID, trigger mode, final status or other fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelTriggerChartRecords")]
        public global::System.Collections.Generic.IList<global::G.ModelTriggerChartRecord>? ModelTriggerChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelTriggerChartRecordsResponse" /> class.
        /// </summary>
        /// <param name="modelTriggerChartRecords">
        /// Model trigger counts. Until we allow filtering or grouping by fields<br/>
        /// like model ID, this list will contain only one element with the<br/>
        /// timeline of trigger counts for a given requester, regardless the model<br/>
        /// ID, trigger mode, final status or other fields.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListModelTriggerChartRecordsResponse(
            global::System.Collections.Generic.IList<global::G.ModelTriggerChartRecord>? modelTriggerChartRecords)
        {
            this.ModelTriggerChartRecords = modelTriggerChartRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelTriggerChartRecordsResponse" /> class.
        /// </summary>
        public ListModelTriggerChartRecordsResponse()
        {
        }
    }
}