//HintName: G.Models.SearchDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class SearchDatasetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int Limit { get; set; } = 5;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}