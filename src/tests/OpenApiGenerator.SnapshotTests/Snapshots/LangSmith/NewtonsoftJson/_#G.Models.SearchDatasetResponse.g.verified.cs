//HintName: G.Models.SearchDatasetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class SearchDatasetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchedFewShotExample> Examples { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}