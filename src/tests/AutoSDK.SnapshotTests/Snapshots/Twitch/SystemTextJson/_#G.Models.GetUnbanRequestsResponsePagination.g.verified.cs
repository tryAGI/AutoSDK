//HintName: G.Models.GetUnbanRequestsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
    /// </summary>
    public sealed partial class GetUnbanRequestsResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Use the cursor to set the request’s after query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}