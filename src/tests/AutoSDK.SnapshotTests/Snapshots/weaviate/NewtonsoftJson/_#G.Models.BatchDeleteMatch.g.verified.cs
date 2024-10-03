//HintName: G.Models.BatchDeleteMatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Outlines how to find the objects to be deleted.
    /// </summary>
    public sealed partial class BatchDeleteMatch
    {
        /// <summary>
        /// Class (name) which objects will be deleted.<br/>
        /// Example: City
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Filter search results using a where filter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("where")]
        public global::G.WhereFilter? Where { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}