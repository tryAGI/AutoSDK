//HintName: G.Models.BatchCallResponseTargetConcurrencyLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
    /// </summary>
    public sealed partial class BatchCallResponseTargetConcurrencyLimit
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}