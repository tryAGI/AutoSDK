//HintName: G.Models.ListMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The standard metadata in the response of a list operation.
    /// </summary>
    public sealed partial class ListMetadata
    {
        /// <summary>
        /// When requesting the next page of this list, this is needed as a query parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_key")]
        public string? PageKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}