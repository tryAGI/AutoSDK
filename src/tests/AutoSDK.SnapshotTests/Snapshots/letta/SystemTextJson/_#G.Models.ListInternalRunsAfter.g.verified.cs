//HintName: G.Models.ListInternalRunsAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Run ID cursor for pagination. Returns runs that come after this run ID in the specified sort order
    /// </summary>
    public sealed partial class ListInternalRunsAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}