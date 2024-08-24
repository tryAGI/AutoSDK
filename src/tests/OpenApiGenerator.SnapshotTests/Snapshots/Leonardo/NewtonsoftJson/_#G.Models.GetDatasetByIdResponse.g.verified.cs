//HintName: G.Models.GetDatasetByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetByIdResponse
    {
        /// <summary>
        /// columns and relationships of "datasets"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasets_by_pk")]
        public global::G.GetDatasetByIdResponseDatasetsByPk? DatasetsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}