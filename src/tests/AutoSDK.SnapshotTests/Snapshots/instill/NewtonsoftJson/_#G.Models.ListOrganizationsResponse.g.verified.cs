//HintName: G.Models.ListOrganizationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOrganizationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations")]
        public global::System.Collections.Generic.IList<global::G.Organization7>? Organizations { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of organizations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}