//HintName: G.Models.QueryConfigConsistencyLevelVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strong consistency. Requires a round-trip to object storage to fetch the latest writes.
    /// </summary>
    public sealed partial class QueryConfigConsistencyLevelVariant1
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}