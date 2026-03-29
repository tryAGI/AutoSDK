//HintName: G.Models.LocalShardTelemetryNumVectorsByName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sum of number of vectors across all segments, grouped by their name. This is an approximate number. Do NOT rely on this number unless you know what you are doing
    /// </summary>
    public sealed partial class LocalShardTelemetryNumVectorsByName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}