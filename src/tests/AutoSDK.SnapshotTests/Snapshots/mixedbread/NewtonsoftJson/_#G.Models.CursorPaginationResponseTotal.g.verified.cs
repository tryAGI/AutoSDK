//HintName: G.Models.CursorPaginationResponseTotal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Total number of items available across all pages. Only included when include_total=true was requested. Expensive operation - use sparingly.
    /// </summary>
    public sealed partial class CursorPaginationResponseTotal
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}