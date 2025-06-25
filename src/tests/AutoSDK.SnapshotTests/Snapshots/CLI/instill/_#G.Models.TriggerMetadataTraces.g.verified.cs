//HintName: G.Models.TriggerMetadataTraces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Each key in the `traces` object is a component ID. The value is a Trace<br/>
    /// object containing the execution details.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class TriggerMetadataTraces
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}