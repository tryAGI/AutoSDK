//HintName: G.Models.AgentScheduleSessionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary metadata to include in each session created by this schedule.<br/>
    /// Default Value: {}<br/>
    /// Example: {"report_type":"daily","format":"markdown"}
    /// </summary>
    public sealed partial class AgentScheduleSessionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}