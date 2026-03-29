//HintName: G.Models.PointsListUpdateFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter to apply when updating existing points. Only points matching this filter will be updated. Points that don't match will keep their current state. New points will be inserted regardless of the filter.
    /// </summary>
    public sealed partial class PointsListUpdateFilter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}