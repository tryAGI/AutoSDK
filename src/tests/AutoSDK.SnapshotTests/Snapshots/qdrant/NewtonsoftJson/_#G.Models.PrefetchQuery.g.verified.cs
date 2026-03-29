//HintName: G.Models.PrefetchQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
    /// </summary>
    public sealed partial class PrefetchQuery
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}