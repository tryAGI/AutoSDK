//HintName: G.Models.ObjectsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of Objects.
    /// </summary>
    public sealed partial class ObjectsListResponse
    {
        /// <summary>
        /// The actual list of Objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::G.Object>? Objects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecations")]
        public global::System.Collections.Generic.IList<global::G.Deprecation>? Deprecations { get; set; }

        /// <summary>
        /// The total number of Objects for the query. The number of items in a response may be smaller due to paging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalResults")]
        public long? TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}